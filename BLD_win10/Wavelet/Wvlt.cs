using System;
//using MathArithmetic;

namespace BLD_win10.Wavelet
{
    /// <summary>
    /// Mallat 快速小波变换
    /// 该小波变换采用的是递归算法,仅二维检验测试有误.
    /// 可以用 Matlab 的非递归算法替代.
    /// </summary>
    public class Wvlt
    {
        public static float[]
        haar = { 0.5f, 0.5f },
        db1 = { 0.5f, 0.5f },
        db2 = { 0.34151f, 0.59151f, 0.15849f, -0.091506f },
        db3 = { 0.23523f, 0.57056f, 0.32518f, -0.095467f, -0.060416f, 0.024909f },
        db4 = { 0.1629f, 0.50547f, 0.4461f, -0.019788f, -0.13225f, 0.021808f, 0.023252f, -0.0074935f },
        db5 = { 0.11321f, 0.42697f, 0.51216f, 0.097883f, -0.17133f, -0.022801f, 0.054851f, -0.0044134f,
            -0.0088959f, -0.019788f, -0.13225f, 0.0023587f },
        db6 = {0.078871f,0.34975f,0.53113f, 0.22292f,
            -0.15999f,-0.091759f, 0.068944f, 0.019462f, -0.022332f, 0.00039163f,
            -0.003378f,-0.00076177f },
        db7 = {0.05505f, 0.2804f, 0.51557f, 0.33219f,
            -0.10176f,-0.15842f, 0.050423f, 0.057002f, -0.026891f, -0.01172f,
            0.0088749f, 0.00030376f, -0.001274f, 0.00025011f },
        db8 = {0.038478f,0.22123f,0.47774f, 0.41391f,
            -0.011193f,-0.20083f, 0.0003341f, 0.091038f, -0.012282f,-0.031175f,
            0.0098861f, 0.0061844f, -0.0034439f, -0.000277f, 0.00047761f, -8.3069e-005f },
        db9 = {0.026925f,0.17242f,0.42767f, 0.46477f, 0.094185f,-0.20738f, -0.068477f, 0.10503f, 0.021726f, -0.047824f,
            0.00017745f, 0.015812f, -0.0033398f, -0.0030275f, 0.0013065f, 0.00016271f, -0.00017816f, 2.7823e+005f },
        db10 ={0.018859f,0.13306f,0.37279f,0.48681f, 0.19882f, -0.17667f, -0.13855f, 0.090064f, 0.065801f,-0.050483f,
            -0.02083f, 0.023485f, 0.0025502f, -0.0075895f, 0.00098666f,0.0014088f,
            -0.00048497f, -8.2355e-005f, 6.6177e-005f, -9.3792e-006f },
        coif2 = {0.011588f, -0.02932f, -0.04764f, 0.27302f, 0.57468f,0.29487f,-0.054086f,-0.042026f,
            0.016744f,0.0039679f,-0.0012892f,-0.00050951f },
        coif3 = {-0.0026824f,0.0055031f,0.016584f,-0.046508f,-0.043221f,0.2865f,0.56129f,0.30298f,
            -0.05077f,-0.058196f,0.024434f,0.011229f,-0.0063696f,-0.0018205f,0.00079021f,
            0.00032967f,-5.0193e-005f,-2.4466e-005f },
        coif4 = {0.00063096f,-0.0011522f,-0.0051945f,0.011362f,0.018867f,-0.057464f,-0.039653f,
            0.29367f,0.55313f,0.30716f,-0.047113f, -0.068038f,0.027814f,0.017736f,-0.010756f,-0.004001f,
            0.0026527f,0.00089559f,-0.0004165f,-0.00018383f,4.408e-005f,2.2083e-005f,
            -2.3049e-006f,-1.2622e-006f},
        dmey = {-7.1418e-013f,6.0242e-009f,-7.8626e-009f,-7.6359e-009f,4.29e-008f,-7.6838e-008f,
            5.7988e-008f, 8.3318e008f, -3.8936e-007f,7.9959e-007f,-1.0533e-006f,5.2097e-007f,
            2.2666e-006f,-1.1535e-005f,4.6346e-005f,-0.00042508f,-0.0019125f,0.0015574f,0.004275f,
            -0.0045168f,-0.0078217f,0.010798f,0.01232f,-0.02272f,-0.017217f,0.04507f,0.021676f,
            -0.093936f,-0.024811f,0.31437f,0.5265f,0.31437f,-0.024811f,-0.093936f,0.021676f,0.04507f,
            -0.017217f,-0.02272f,0.01232f,0.010798f,-0.0078217f,-0.0045168f,0.004275f,0.0015574f,
            -0.0019125f,-0.00042508f,4.6346e-005f,-1.1535e-005f , 2.2666e-006f,5.2097e-007f,
            -1.0533e-006f, 7.9959e-007f,-3.8936e-007f, 8.3318e-008f, 5.7988e-008f,-7.6838e-008f,4.29e-008f,
            -7.6359e-009f,-7.8626e-009f,6.0242e-009f,-7.1418e-013f,0 },
        df2_2 = { -0.1250f, 0.2500f, 0.7500f, 0.2500f, -0.1250f },
        rf2_2 = { 0.2500f, 0.5000f, 0.2500f },
        df1_3 = { -0.0625f, 0.0625f, 0.5000f, 0.5000f, 0.0625f, -0.0625f },
        rf1_3 = { 0.5f, 0.5f },
        df1_5 = { 0.0117f, -0.0117f, -0.0859f, 0.0859f, 0.5000f, 0.5000f, 0.0859f, -0.0859f },
        rf1_5 = { 0.5f, 0.5f },
        df3_1 = { -0.2500f, 0.7500f, 0.7500f, -0.2500f },
        rf3_1 = { 0.1250f, 0.3750f, 0.3750f, 0.1250f },
        df4_4 = { 0.0267f, -0.0169f, -0.0782f, 0.2669f, 0.6029f, 0.2669f, -0.0782f, -0.0169f, 0.0267f },
        rf4_4 = { -0.0456f, -0.0288f, 0.2956f, 0.5575f, 0.2956f, -0.0288f, -0.0456f },
        df5_5 = { 0.0281f, 0.0056f, -0.0385f, 0.2444f, 0.5209f, 0.2444f, -0.0385f, 0.0056f, 0.0281f },
        rf5_5 = { 0.0095f, -0.0019f, -0.0967f, -0.0661f, 0.3372f, 0.6360f, 0.3372f, -0.0661f, -0.0967f, -0.0019f, 0.0095f },
        df6_8 = {0.0013f,-0.0014f,-0.0120f, 0.0084f, 0.0352f ,-0.0546f, -0.0665f,
            0.2975f,0.5840f,0.2975f,-0.0665f, -0.0546f, 0.0352f, 0.0084f, -0.0120f,-0.0014f,0.0013f },
        rf6_8 = { -0.0102f, -0.0102f ,0.0557f,0.0285f,-0.2955f, -0.5366f, -0.2955f,
            0.0285f,0.0557f, -0.0102f, -0.0102f };

        protected
        Seq LPrime,
        Lo_D, Hi_D, //Decomposition of Low_Pass,High_Pass 
        Lo_R, Hi_R; //Reconstruction of Low_Pass,High_Pass 
                    /*
                    [RF, DF] = biorwavf(W) returns two scaling filters associated with the
                    biorthogonal wavelet specified by the string W.W = 'biorNr.Nd' where possible values for 
                    Nr and Nd areNr = 1 Nd = 1, 3 or 5 Nr = 2 Nd = 2,4, 6 or 8Nr = 3Nd = 1, 3, 5, 7 or 9Nr
                    = 4 Nd = 4 Nr = 5 Nd = 5 Nr = 6 Nd = 8The output arguments are filters.RF is the
                    reconstruction filter.DF is the decomposition filter.Examples% Set spline biorthogonal
                    wavelet name.
                    wname = 'bior2.2'; 
                    % Compute the two corresponding scaling filters.
                    % rf is the reconstruction scaling filter. 
                    % df is the decomposition scaling filter. 
                    [rf, rd] = biorwavf(wname) 
                    0.2500 
                    df = -0.1250 
                    0.5000 
                    0.2500 
                    0.2500 
                    0.7500 
                    0.2500 -0.1250 */
                    // Construct orthogonal wavelet with coeffients from array fv 
        public Wvlt(float[] fv)
        {
            LPrime = new Seq(fv);
            GetFilters(LPrime);
        }

        public Wvlt(string fltnm)
        {
            switch (fltnm)
            {
                case "haar":
                case "dbl ": LPrime = new Seq(db1); GetFilters(LPrime); break;
                case "db2": LPrime = new Seq(db2); GetFilters(LPrime); break;
                case "db3": LPrime = new Seq(db3); GetFilters(LPrime); break;
                case "db4": LPrime = new Seq(db4); GetFilters(LPrime); break;
                case "db5": LPrime = new Seq(db5); GetFilters(LPrime); break;
                case "db6": LPrime = new Seq(db6); GetFilters(LPrime); break;
                case "db7": LPrime = new Seq(db7); GetFilters(LPrime); break;
                case "db8": LPrime = new Seq(db8); GetFilters(LPrime); break;
                case "db9": LPrime = new Seq(db9); GetFilters(LPrime); break;
                case "db10": LPrime = new Seq(db10); GetFilters(LPrime); break;
                case "coif2": LPrime = new Seq(coif2); GetFilters(LPrime); break;
                case "coif3": LPrime = new Seq(coif3); GetFilters(LPrime); break;
                case "coif4": LPrime = new Seq(coif4); GetFilters(LPrime); break;
                case "dmey": LPrime = new Seq(dmey); GetFilters(LPrime); break;
                case "biorl.3": Lo_R = new Seq(rf1_3); Lo_D = new Seq(df1_3); CalcuBior(); break;
                case "biorl.5": Lo_R = new Seq(df1_5); Lo_D = new Seq(df1_5); CalcuBior(); break;
                case "bior2.2": Lo_R = new Seq(df2_2); Lo_D = new Seq(df2_2); CalcuBior(); break;
                case "bior3.1": Lo_R = new Seq(df3_1); Lo_D = new Seq(df3_1); CalcuBior(); break;
                case "bior4.4": Lo_R = new Seq(df4_4); Lo_D = new Seq(df4_4); CalcuBior(); break;
                case "bior5.5": Lo_R = new Seq(df5_5); Lo_D = new Seq(df5_5); CalcuBior(); break;
                case "bior6.8": Lo_R = new Seq(df6_8); Lo_D = new Seq(df6_8); CalcuBior(); break;
                default: LPrime = new Seq(db1); GetFilters(LPrime); break;
            }
        }

        public void CalcuBior()
        {
            Lo_R = 1.0f / Lo_D.Norm() * Lo_R;
            Hi_R = Lo_R.Qmf();
            Lo_D = 1.0f / Lo_D.Norm() * Lo_D;
            Hi_D = Hi_R.Wrev();
        }

        /// <summary>
        /// 根据给定滤波器,产生两对孪生小波变换基对象
        /// </summary>
        /// <param name="w"></param>
        public void GetFilters(Seq w)
        {
            //w.Norm() = 0.7071; 
            float nw = 1 / w.Norm();
            Lo_R = nw * w;
            Hi_R = Lo_R.Qmf();
            Lo_D = Lo_R.Wrev();
            Hi_D = Hi_R.Wrev();
        }

        /// <summary>
        /// 一维 Mallat 快速小波正变换
        /// </summary>
        /// <param name="fv"></param>
        /// <param name="lev"></param>
        /// <returns></returns>
        public Seq fwt(Seq fv, int lev)
        {
            Seq tmp = fv;
            if (lev == 0)
            {
                tmp = fv;
            }
            else
            {
                lev /= 2;
                Seq low = Lo_D * fv;
                low = low.Wkeep(fv.Length).Dyaddown();
                Seq high = Hi_D * fv;
                high = high.Wkeep(fv.Length).Dyaddown();
                tmp = fwt(low, lev);
                tmp = tmp.Concatenate(high);
            }
            return tmp;
        }

        /// <summary>
        /// 一维 Mallat 快速小波反变换
        /// </summary>
        /// <param name="fv"></param>
        /// <param name="lev"></param>
        /// <returns></returns>
        public Seq ifwt(Seq fv, int lev)
        {
            Seq tmp = fv, low, high;
            int keeplen;
            if (lev == 0)
            {
                tmp = fv;
            }
            else
            {
                lev /= 2;
                fv.Split2(out low, out high);
                keeplen = low.Length * 2;
                tmp = ifwt(low, lev);
                Seq rlow = Lo_R * tmp.Dyadup();
                Seq rhigh = Hi_R * high.Dyadup();
                tmp = rlow + rhigh;
                tmp = tmp.Wkeep(keeplen);
            }
            return tmp;
        }

        /// <summary>
        /// 求二进波序列分块数\最小块长度
        /// </summary>
        /// <param name="len">序列长度</param>
        /// <param name="lev">尺度大小</param>
        /// <param name="numblocks">分块数</param>
        /// <param name="baselen">最小块长度</param>
        private static void GetBlocksAndBaseLen(
            int len, int lev, out int numblocks, out int baselen)
        {
            int mb = (int)Math.Log(len, 2);
            numblocks = mb - lev;
            baselen = (int)(len / Math.Pow(2, numblocks));
            //baselen = len;
            //numblocks = 0;
            //int n2 = (1 << lev);//2^lev
            //while (baselen >= n2)
            //{
            //    numblocks++;
            //    baselen = baselen >> 1; //baselen / 2 
            //}
            //baselen = baselen << 1;
            //numblocks--;
        }

        /// <summary>
        /// 获取 mat 中的 rid行
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="mat"></param>
        /// <returns></returns>
        public float[] GetRow(int rid, float[,] mat)
        {
            int cols = mat.GetLength(1);
            float[] row = new float[cols];
            for (int j = 0; j < cols; j++)
                row[j] = mat[rid, j];
            return row;
        }

        /// <summary>
        /// 设置 mat中的 rid 行
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="row"></param>
        /// <param name="mat"></param>
        public void SetRow(int rid, float[] row, float[,] mat)
        {
            int cols = mat.GetLength(1);
            for (int j = 0; j < cols; j++)
                mat[rid, j] = row[j];
        }

        /// <summary>
        /// 获取 mat 中的 cid 列
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="mat"></param>
        /// <returns></returns>
        public float[] GetCol(int cid, float[,] mat)
        {
            int rows = mat.GetLength(0);
            float[] col = new float[rows];
            for (int i = 0; i < rows; i++)
                col[i] = (float)mat[i, cid];
            return col;
        }

        /// <summary>
        /// 设置 mat 中的 cid 列
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="col"></param>
        /// <param name="mat"></param>
        public void SetCol(int cid, float[] col, float[,] mat)
        {
            int rows = mat.GetLength(0);
            for (int i = 0; i < rows; i++)
                mat[i, cid] = col[i];
        }

        /// <summary>
        /// 二维 Mallat 快速小波正变换
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="wlev"></param>
        /// <param name="hlev"></param>
        /// <returns></returns>
        public virtual float[,] fwt2(float[,] fi, int wlev, int hlev)
        {
            int rows = fi.GetLength(0), cols = fi.GetLength(1);
            float[,] wt = new float[rows, cols];
            Seq tmp;
            int i;
            for (i = 0; i < rows; i++)
            {
                tmp = new Seq(GetRow(i, fi));
                tmp = fwt(tmp, wlev);
                SetRow(i, tmp.elements, wt);
            }
            for (i = 0; i < cols; i++)
            {
                tmp = new Seq(GetCol(i, wt));
                tmp = fwt(tmp, hlev);
                SetCol(i, tmp.elements, wt);
            }
            return wt;
        }

        /// <summary>
        /// 二维 Mallat 快速小波反变换
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="wlev"></param>
        /// <param name="hlev"></param>
        /// <returns></returns>
        public virtual float[,] ifwt2(float[,] fi, int wlev, int hlev)
        {
            int rows = fi.GetLength(0), cols = fi.GetLength(1);
            float[,] iwt = (float[,])fi.Clone();
            Seq tmp;
            int i;
            for (i = 0; i < cols; i++)
            {
                tmp = new Seq(GetCol(i, iwt));
                tmp = ifwt(tmp, hlev);
                SetCol(i, tmp.elements, iwt);
            }
            for (i = 0; i < rows; i++)
            {
                tmp = new Seq(GetRow(i, iwt));
                tmp = ifwt(tmp, wlev);
                SetRow(i, tmp.elements, iwt);
            }
            return iwt;
        }

        /// <summary>
        /// 二维小波变换后的块数
        /// </summary>
        /// <param name="numblocks"></param>
        /// <returns></returns>
        private static int GetDim2Blocks(int numblocks)
        {
            int a0 = 4, d = 3, an = a0 + (numblocks - 1) * d;//等差数列末项是块矩阵数
            return an;
        }
    }
}