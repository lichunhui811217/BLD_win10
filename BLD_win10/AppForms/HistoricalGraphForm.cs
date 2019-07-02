using BLD_win10.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BLD_win10.AppForms
{
    public partial class HistoricalGraphForm : Form
    {
        private System.Drawing.Drawing2D.GraphicsPath mousePath;

        public HistoricalGraphForm()
        {
            mousePath = new System.Drawing.Drawing2D.GraphicsPath();

            InitializeComponent();
        }

        Random random = new Random();

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl1.Controls.Clear();

            #region 根据锅炉信息,生成选项卡 TabPage
            foreach (Boiler boiler in DevicesDataCenter.boilersList)
            {
                // 定义控件和控件之间的关系
                TabPage tabPage = new TabPage();
                SplitContainer splitContainer = new SplitContainer();
                TreeView treeView = new TreeView();             //左侧树状菜单
                Chart chart = new Chart();       //右侧显示曲线 chart控件
                tabControl1.Controls.Add(tabPage);

                #region TabPage
                tabPage.Parent = tabControl1;
                tabPage.Name = "tabPage_" + boiler.BoilerID;
                tabPage.Text = boiler.Caption;
                tabPage.Padding = new Padding(12);
                tabPage.TabIndex = 0;
                tabPage.Text = boiler.Caption;
                tabPage.UseVisualStyleBackColor = true;
                tabPage.Controls.Add(splitContainer);
                #endregion

                #region TreeView
                treeView.Parent = splitContainer.Panel1;
                treeView.Name = "treeView_" + boiler.BoilerID.ToString();
                treeView.Dock = DockStyle.Fill;
                treeView.CheckBoxes = true;
                treeView.AfterCheck += TreeView_AfterCheck;
                treeView.Nodes.Add(new TreeNode("蒸汽流量"));
                treeView.Nodes.Add(new TreeNode("吹灰状态"));
                foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
                {
                    if (aSensor.BoilerID == boiler.BoilerID)
                    {
                        TreeNode treeNode = new TreeNode(
                            "通道" + aSensor.SensorID.ToString(),
                            new TreeNode[] {
                                new TreeNode("噪声值"),
                                new TreeNode("报警上限"),
                                new TreeNode("泄漏概率")
                            });
                        //treeNode.ExpandAll();
                        treeView.Nodes.Add(treeNode);
                    }
                }
                #endregion

                #region splitContainer
                //this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
                //resources.ApplyResources(this.splitContainer1, "splitContainer1");
                //this.splitContainer1.Name = "splitContainer1";

                splitContainer.Name = "splitContainer_" + boiler.BoilerID;
                splitContainer.BackColor = Color.WhiteSmoke;
                //splitContainer.Parent = tabPage;
                splitContainer.Dock = DockStyle.Fill;
                splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
                //splitContainer.Location = new Point(20, 20);
                splitContainer.SplitterDistance = 180;
                splitContainer.SplitterWidth = 10;

                #endregion

                #region splitContainer.Panel1
                splitContainer.Panel1.BackColor = Color.Transparent;
                #endregion

                #region splitContainer.Panel2
                splitContainer.Panel2.BackColor = Color.Transparent;
                #endregion

                #region Chart 绘制图表
                ((ISupportInitialize)chart).BeginInit();
                splitContainer.Panel2.Controls.Add(chart);
                chart.Name = "_Chart";
                chart.Palette = ChartColorPalette.None;
                chart.BorderlineColor = Color.Black;
                chart.BorderlineDashStyle = ChartDashStyle.Solid;
                chart.Dock = DockStyle.Fill;

                chart.MouseMove += Chart_MouseMove;

                //清空图表内容
                chart.Titles.Clear();
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Legends.Clear();

                //图表区
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorTickMark.Enabled = false;
                chartArea.Name = "_ChartArea";
                chart.ChartAreas.Add(chartArea);

                //图例
                Legend legend = new Legend
                {
                    IsDockedInsideChartArea = false,
                    Name = "_Legend"
                };
                chart.Legends.Add(legend);
                //图例2 坐标
                Legend legend2 = new Legend
                {
                    IsDockedInsideChartArea = false,
                    Name = "_Legend2"
                };

                //表头
                Title title = new Title
                {
                    DockedToChartArea = "_ChartArea",
                    IsDockedInsideChartArea = false,
                    Name = "_Title",
                    Text = boiler.Caption
                };
                chart.Titles.Add(title);

                ((ISupportInitialize)chart).EndInit();
                #endregion
            }
            #endregion

            this.ResumeLayout();
        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {

            // Update the mouse path that is drawn onto the Panel.
            int mouseX = e.X;
            int mouseY = e.Y;
            Chart chart = (Chart)sender;
            foreach (Series series in chart.Series)
            {
                //series.LegendText = series.Name + "x:" + mouseX + ",y:"+ mouseY;

                HitTestResult myTestResult = chart.HitTest(e.X, e.Y);
                if (myTestResult.ChartElementType == ChartElementType.DataPoint)
                {
                    this.Cursor = Cursors.Cross;
                    int i = myTestResult.PointIndex;
                    DataPoint dp = myTestResult.Series.Points[i];
                    int x = Convert.ToInt32(dp.XValue);
                    double y = series.Points[x-1].YValues[0];
                    //自我实现值的显示      
                    series.LegendText = series.Name + "x:" + x + ",y:" + y;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }
            //mousePath.add
            //mousePath.AddLine(mouseX -100, mouseY-100, mouseX, mouseY);
            //throw new NotImplementedException();

            
                
        }

        /// <summary>
        /// 点选更新树状菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }

                DrowChart(e.Node.TreeView);
            }
        }

        /// <summary>
        /// 画曲线图
        /// </summary>
        /// <param name="node"></param>
        private void DrowChart(TreeView treeView)
        {
            SplitContainer splitContainer = (SplitContainer)treeView.Parent.Parent;
            Chart chart = (Chart)splitContainer.Panel2.Controls.Find("_Chart", false)[0];
            Legend legend = chart.Legends[0];
            ChartArea chartArea = chart.ChartAreas[0];
            chart.Series.Clear();

            foreach (TreeNode treeNode in treeView.Nodes)
            {
                DrowSeries(treeNode, chart, chartArea);
            }
        }

        /// <summary>
        /// 递归画所有点的曲线
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="chart"></param>
        /// <param name="chartArea"></param>
        private void DrowSeries(TreeNode treeNode, Chart chart, ChartArea chartArea)
        {
            if (treeNode.Checked && !treeNode.Text.StartsWith("通道"))
            {
                Series series = new Series();
                if (treeNode.Text == "蒸汽流量" || treeNode.Text == "吹灰状态")
                {
                    series.Name = treeNode.Text.ToString();
                }
                else if (treeNode.Parent.Text.StartsWith("通道"))
                {
                    series.Name = treeNode.Parent.Text.ToString() + "_" + treeNode.Text.ToString();
                }
                else
                {
                    series.Name = treeNode.Text.ToString();
                }

                series.ChartType = SeriesChartType.Spline;
                series.ChartArea = chartArea.Name;
                series.ToolTip = "#SER:#VAL";
                for (int i = 1; i <= 50; i++)
                {
                    series.Points.Add(new DataPoint(i, random.Next()));
                }
                chart.Series.Add(series);
            }

            foreach (TreeNode t in treeNode.Nodes)
            {
                DrowSeries(t, chart, chartArea);
            }
        }

        /// <summary>
        /// Updates all child tree nodes recursively.
        /// </summary> 
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        /// <summary>
        /// 图表区数据更新 TODO : 现在是随机数据, 以后需要和 Driver 或 DataBase 连接.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void histogramChart_Click(object sender, EventArgs e)
        {
            foreach (Series aSeries in histogramChart.Series)
            {
                aSeries.Points.Clear();
            }

            foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
            {
                //数据点的填充
                double tempData = random.NextDouble() * 10.0;  //取随机数*10 填充Y值 TODO:
                Series series = histogramChart.Series.FindByName("Series_" + aSensor.BoilerID.ToString());
                series.Points.Add(aSensor);
                aSensor.SetYValue(tempData);

                ChartArea chartArea = histogramChart.ChartAreas.FindByName("ChartArea_" + aSensor.BoilerID.ToString());//按名称填充ChartAreas.Series

                //按点生成X轴
                CustomLabel customLabel = new CustomLabel
                {
                    FromPosition = aSensor.XValue - 0.5,
                    ToPosition = aSensor.XValue + 0.5,
                    Text = aSensor.XValue.ToString()
                };
                chartArea.AxisX.CustomLabels.Add(customLabel);
            }
        }
    }
}