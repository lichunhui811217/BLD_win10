using System;
using System.Diagnostics;

namespace BLD_win10.Wavelet
{
    /// <summary> 
    /// Seq 
    /// </summary> 
    public class Seq
    {
        public float[] elements = null;
        public Seq()
        {
            elements = new float[0];
        }
        public Seq(int Len)
        {
            elements = new float[Len];
        }
        public Seq(float[] elt)
        {
            elements = new float[elt.Length];
            elt.CopyTo(elements, 0);
        }
        public Seq(double[] elt)
        {
            elements = new float[elt.Length];
            for (int i = 0; i < elt.Length; i++) elements[i] = (float)elt[i];
        }
        public Seq(Seq s)
        {
            elements = new float[s.Length];
            s.elements.CopyTo(elements, 0);
        }
        //Length of sequence 
        public int Length
        {
            get
            {
                return elements.Length;
            }
        }
        public float this[int index]
        {
            get
            {
                Debug.Assert(0 <= index);
                return elements[index];
            }
            set
            {
                Debug.Assert(0 <= index);
                elements[index] = value;
            }
        }
        public void Split2(out Seq sl, out Seq s2)
        {
            int i, half = Length / 2;
            float[]
            A = new float[half],
            D = new float[half];
            for (i = 0; i < A.Length; i++) A[i] = this[i];
            for (i = 0; i < D.Length; i++) D[i] = this[i + half];
            sl = new Seq(A);
            s2 = new Seq(D);
        }
        public Seq Concatenate(Seq s)
        {
            if (Length == 0) return s;
            int len = Length + s.Length;
            float[] d = new float[len];
            elements.CopyTo(d, 0);
            for (int i = 0; i < s.Length; i++)
            {
                d[Length + i] = s[i];
            }
            return new Seq(d);
        }
        public bool IsOdd
        {
            get
            {
                return (Length % 2 != 0);
            }
        }
        public bool IsEven
        {
            get
            {
                return (Length % 2 == 0);
            }
        }
        static public bool operator ==(Seq a, Seq b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
        static public bool operator !=(Seq a, Seq b)
        {
            return !(a == b);
        }
        public override bool Equals(object o)
        {
            if (o is Seq)
            {
                Seq s = (Seq)o;
                return (this == s);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        static public Seq operator +(Seq sl, Seq s2)
        {
            Seq sum = new Seq(sl.Length);
            for (int i = 0; i < sl.Length; i++) sum[i] = sl[i] + s2[i];
            return sum;
        }
        static public Seq operator -(Seq sl, Seq s2)
        {
            Seq sum = new Seq(sl.Length);
            for (int i = 0; i < sl.Length; i++) sum[i] = sl[i] - s2[i];
            return sum;
        }

        /// <summary>
        /// 边缘处理
        /// </summary>
        /// <param name="x"></param>
        /// <param name="xsize"></param>
        /// <returns></returns>
        static private int Edge(int x, int xsize)
        {
            while ((x < 0) || (x >= xsize)) 
                {
                if (x < 0) x = -x;
                if (x >= xsize)
                    x = xsize * 2 - x - 2;
            }
            return x;
        }

        /// <summary>
        /// 卷积
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static public Seq operator *(Seq s1, Seq s2)
        {
            //Seq ss2 = SymmetricExtension(s2); 
            Seq con = new Seq(s1.Length + s2.Length - 1);
            int i, j, k;
            for (i = 0; i < con.Length; i++)
            {
                con[i] = 0.0f;
                for (j = 0; j < s1.Length; j++)
                {
                    k = i - j;
                    con[i] += s1[j] * s2[Edge(k, s2.Length)];
                    //if (k >= 0 && k < s2.Length) con[i] += sl [j] 
                }
            }
            return con;
        }
        static public Seq operator *(float d, Seq s)
        {
            Seq m = new Seq(s);
            for (int i = 0; i < m.Length; i++) m[i] *= d;
            return m;
        }

        /// <summary>
        /// 反转
        /// </summary>
        /// <returns></returns>
        public Seq Wrev()
        {
            Seq tr = new Seq(Length);
            for (int i = 0; i < Length; i++)
                tr.elements[i] = elements[Length - 1 - i];
            return tr;
        }

        /// <summary>
        /// 积分镜像过滤
        /// </summary>
        /// <returns></returns>
        public Seq Qmf()
        {
            //Quadrature mirror filter 
            Seq tr = Wrev().Altsign();
            return tr;
        }

        /// <summary>
        /// 间隔变号
        /// </summary>
        /// <returns></returns>
        public Seq Altsign()
        {
            Seq alt = new Seq(this);
            int sign = 1;
            for (int i = 0; i < Length; i++)
            {
                alt[i] *= sign;
                sign = -1;
            }
            return alt;
        }

        /// <summary>
        /// 返回间隔抽样
        /// </summary>
        /// <returns></returns>
        public Seq Dyaddown()
        {
            Seq down = new Seq(Length / 2);
            for (int i = 0; i < down.Length; i++) down[i] = this[2 * i];
            return down;
        }

        /// <summary>
        /// 倍增样本
        /// </summary>
        /// <returns></returns>
        public Seq Dyadup()
        {
            Seq up = new Seq(Length * 2);
            for (int i = 0; i < up.Length; i++)
                up[i] = (i % 2 == 0) ? 0.0f : this[i / 2];
            return up;
        }

        /// <summary>
        /// 返回序列中间部分    见Matlab wkeep
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public Seq Wkeep(int len)
        {
            if (len >= Length) return new Seq(this);
            Seq keep = new Seq(len);
            int dif = Length - len, start = dif / 2;
            if ((start == 0) && (dif > 0)) start = 1;
            for (int i = 0; i < len; i++)
            {
                keep[i] = this[i + start];
            }
            return keep;
        }

        /// <summary>
        /// 模2
        /// </summary>
        /// <returns></returns>
        public float Norm()
        {
            float sum = 0.0f;
            for (int i = 0; i < Length; i++)
            {
                sum += this[i] * this[i];
            }
            sum = (float)Math.Sqrt(sum);
            return sum;
        }

        /// <summary>
        /// 合计
        /// </summary>
        /// <returns></returns>
        public float Sum()
        {
            float sum = 0.0f;
            for (int i = 0; i < Length; i++)
            {
                sum += this[i];
            }
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EleStr()
        {
            string s = "";
            int i;
            for (i = 0; i < Length; i++)
            {
                s += String.Format("{0:d} {1:f},", i, elements[i]);
            }
            return s + "\n";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EleFrequencyStr()
        {
            float delta = (float)(Math.PI / Length);
            string s = "";
            for (float w = 0.0f; w <= Math.PI; w += delta)
            {
                double rsum = 0.0f, isum = 0.0f;
                for (int n = 0; n <= Length; n++)
                {
                    rsum += this[n] * Math.Cos(-n * w);
                    isum += this[n] * Math.Sin(-n * w);
                }
                double
                hypot = Math.Sqrt(rsum * rsum + isum * isum),
                atan2 = Math.Atan2(isum, rsum);
                s += String.Format("w={0:f}, hypot={1:f}, atan2= {2:f}", w, hypot, atan2);
            }
            return s + "In";
        }
    }
}
