using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyDijkstra
{
	public partial class Form1 : Form
	{
		bool readyPoint = false;
		bool readyEdges = false;
		bool displayRoad = false;
		Point[] point = new Point[21];
		int numberPoints;
		int numberEdges;
		int startPoint;
		int endPoint;
		int[,] matrix = new int[21, 21];
		MyDijkstra[] myDijkstra = new MyDijkstra[21];
		public Form1()
		{
			InitializeComponent();
		}




		private void panel_graphic_Paint(object sender, PaintEventArgs e)
		{
			// pen have arrow
			Pen p = new Pen(Color.Green, 2);
			AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
			p.CustomEndCap = bigArrow;

			// pen havent arrow
			Pen pen = new Pen(Color.Black, 2);

			Pen penStart = new Pen(Color.Black, 4);
			Pen penEnd = new Pen(Color.Yellow, 4);
			// standard not startpoint and endpoint
			SolidBrush br = new SolidBrush(Color.Red);

			// pen : startPoint
			SolidBrush brStart = new SolidBrush(Color.GreenYellow);
			// pen: endPoint
			SolidBrush brEnd = new SolidBrush(Color.Purple);

			Graphics gr = panel_graphic.CreateGraphics();
			/// create point 
			if (readyPoint)
			{
				for (int i = 1; i <= numberPoints; i++)
				{

					gr.FillEllipse(br, CTD(point[i]).X - 5, CTD(point[i]).Y - 5, 25, 25);
					gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(point[i]).X, CTD(point[i]).Y);
				}
			}
			//draw line
			if (readyEdges == true && readyPoint == true)
			{
				for (int h = 1; h <= numberPoints; h++)
				{
					for (int k = 1; k <= numberPoints; k++)
					{
						if (matrix[h, k] != 0)

							gr.DrawLine(pen, CTD(point[h]), CTD(point[k]));
					}
				}
				Point tempPoint = new Point();
				for (int i = 1; i <= numberPoints; i++)
				{
					for (int j = 1; j <= numberPoints; j++)
					{
						if (matrix[i, j] != 0)
						{
							tempPoint = midPoint(i, j);
							//Hien thi do dai tai trung diem
							gr.DrawString(matrix[i, j].ToString(), new Font("Consolas", 12), new SolidBrush(Color.DodgerBlue), CTD(tempPoint));
						}
					}

				}
			}
			if (displayRoad == true && checkStartPointEndPoint() == true)
			{

				int tempSau = endPoint;
				/**/
				// color startpoint and endpoint
				for (int i = 1; i <= numberPoints; i++)
				{
					if (i == startPoint || i == endPoint)
					{
						continue;

					}
					gr.FillEllipse(br, CTD(point[i]).X - 5, CTD(point[i]).Y - 5, 25, 25);
					gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(point[i]).X, CTD(point[i]).Y);
				}
				// vẽ điểm đầu và điểm cuối sau những điểm thường
				gr.FillEllipse(brStart, CTD(point[startPoint]).X - 5, CTD(point[startPoint]).Y - 5, 25, 25);
				gr.DrawString(startPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(point[startPoint]).X, CTD(point[startPoint]).Y);

				gr.FillEllipse(brEnd, CTD(point[endPoint]).X - 5, CTD(point[endPoint]).Y - 5, 25, 25);
				gr.DrawString(endPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(point[endPoint]).X, CTD(point[endPoint]).Y);
				while (true)
				{

					int tempTruoc = myDijkstra[tempSau].Point;
					gr.DrawLine(p, CTD(point[tempTruoc]), CTD(point[tempSau]));

					if (tempTruoc == startPoint) break;
					tempSau = tempTruoc;

				}

			}


		}
		private void excute()
		{

			resetDijkstra();
			//init mydijkstra
			for (int i = 1; i <= numberPoints; i++)
			{
				myDijkstra[i].Point = startPoint;
			}
			myDijkstra[startPoint].Length = 0;
			myDijkstra[startPoint].Point = startPoint;
			myDijkstra[startPoint].IsCheck = true;

			// excute 
			int tempMark = startPoint;
			int sum = 0;
			while (true)
			{

				// tinh do dai den cac diem ke cua diem hien tai tempMark
				for (int i = 1; i <= numberPoints; i++)
				{
					if (myDijkstra[i].IsCheck == true) continue;

					// neu chu ta xem co ke hay khong
					if (matrix[i, tempMark] != 0)
					{
						if (myDijkstra[i].IsCheck == false) sum++;
						if (myDijkstra[i].Length == -1 || myDijkstra[tempMark].Length + matrix[i, tempMark] < myDijkstra[i].Length)
						{
							myDijkstra[i].Length = myDijkstra[tempMark].Length + matrix[i, tempMark];
							myDijkstra[i].Point = tempMark;
						}
					}

				}
				// find min point
				//  sum = 0;
				int dMin = 1000000;
				int tempi = 0;
				int conti = 0;
				for (int i = 1; i <= numberPoints; i++)
				{
					if (myDijkstra[i].IsCheck == true || myDijkstra[i].Length == -1) continue;

					if (myDijkstra[i].Length < dMin)
					{
						dMin = myDijkstra[i].Length;
						tempi = i;
						conti++;
					}

				}

				if (conti == 0) break;
				// danh dau va cap nhat lai diem duoc chon
				// history[tempi].DiemDiToi = tempMark;
				myDijkstra[tempi].IsCheck = true;
				tempMark = tempi;
				if (tempMark == endPoint) break;
			} // end dijkstra



			if (myDijkstra[endPoint].Length == -1)
				txtLog.Text = "Not exist path from " + startPoint + " to " + endPoint;
			else
			{
				String log = "The cost from " + startPoint + " to " + endPoint + " is: " + myDijkstra[endPoint].Length +"     Path is ";
				String path = "";
				int tempSau = endPoint;
				while (true)
				{

					int tempTruoc = myDijkstra[tempSau].Point;
					path = tempTruoc + "-->" + path;

					if (tempTruoc == startPoint) break;
					tempSau = tempTruoc;
				}
				txtLog.Text = log + path + endPoint;
				displayRoad = true;
				panel_graphic.Invalidate();
				panel_graphic.Refresh();
			}
		}
		private void resetDijkstra()
		{
			for (int i = 0; i <= 20; i++)
			{
				myDijkstra[i] = new MyDijkstra();
			}


		}
		private bool checkStartPointEndPoint()
		{
			startPoint = int.Parse(txtStartPoint.Text);
			endPoint = int.Parse(txtEndPoint.Text);
			if (startPoint != 0 && endPoint != 0)
				return true;
			else return false;
		}
		private Point midPoint(int x, int y)
		{
			Point td = new Point();
			td.X = (point[x].X + point[y].X) / 2;
			td.Y = (point[x].Y + point[y].Y) / 2;
			return td;
		}

		// Chi gianh cho ve chi so diem va 2 dau mut cua 1 doan thang
		public Point CTD(Point pt)
		{
			int k = panel_graphic.Height / 205;

			pt.X = pt.X * k ;
			pt.Y = pt.Y * k ;
			return pt;
		}



		private void btnPoint_Click(object sender, EventArgs e)
		{
			if (txtPoint.Text == null || txtPoint.Text == "")
			{
				return;
			}
			if (int.Parse(txtPoint.Text) > 20)
			{
				string message = "Nhập vào số điểm không quá 20";
				string caption = "Nhập sai dữ liệu";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;

				// Displays the MessageBox.
				result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
				return;
			}

			numberPoints = int.Parse(txtPoint.Text);
			Random rd = new Random();
			int t = 1;
			while (true)
			{
				if (t > numberPoints) break;
				//    TaoDiem(t);
				point[t].X = rd.Next(0, 200) + 50;
				point[t].Y = rd.Next(0, 200);

				t++;
			}
			readyPoint = true;

			panel_graphic.Invalidate();
			panel_graphic.Refresh();

		}
		private int maxEdges()
		{
			int number = int.Parse(txtPoint.Text);
			int maxEdges;
			if (number == 0 || number == 1)
			{
				return 0;
			}
			else
			{
				maxEdges = (number*(number-1))/ 2;
				return maxEdges;
			}
		}
		private void btnPath_Click(object sender, EventArgs e)
		{
			if (!readyPoint)
			{
				string message = "Enter the number";
				string caption = "ERROR";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;

				// Displays the MessageBox.

				result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
				return;
			}
			if (txtPath.Text == null || txtPath.Text == "")
			{
				return;
			}
			if (int.Parse(txtPath.Text) > 20)
			{
				string message = "Enter the number not greater than  " + maxEdges();
				string caption = "ERROR";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
			}

			numberEdges = int.Parse(txtPath.Text);
			if (numberEdges > maxEdges())
			{
				return;
			}
			readyEdges = true;
			initMatrix();
			Random rd2 = new Random();
			int x, y, d;
			// Cac diem dau va cuoi khong trung nhau, canh k dc lap lai
			int t = 0;
			while (true)
			{
				if (t == numberEdges) break;
				x = rd2.Next(1, numberPoints + 1); // Ham random(x,y) chỉ chay tu x-> (y-1) nên cộng thêm 1 đơn vị 
				y = rd2.Next(1, numberPoints + 1);
				if (matrix[x, y] != 0 || x == y) continue;
				d = distanceEdge(x, y);
				matrix[x, y] = d;
				matrix[y, x] = d;
				t++;
			}
			panel_graphic.Invalidate();
			panel_graphic.Refresh();

		}
		//
		private int distanceEdge(int a, int b)
		{
			int d = 0;
			d = Convert.ToInt32(Math.Sqrt((point[a].X - point[b].X) * (point[a].X - point[b].X) + (point[a].Y - point[b].Y) * (point[a].Y - point[b].Y)));
			return d;
		}
		//init matrix
		private void initMatrix()
		{
			for (int i = 1; i <= 20; i++)
			{
				for (int j = 1; j <= 20; j++)
				{
					matrix[i, j] = 0;
				}
			}
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			txtPoint.Enabled = false;
			txtPath.Enabled = false;
			startPoint = int.Parse(txtStartPoint.Text);
			endPoint = int.Parse(txtEndPoint.Text);
			excute();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			//
			txtPoint.Text = "";
			txtPath.Text = "";
			txtStartPoint.Text = "";
			txtEndPoint.Text = "";
			txtPoint.Enabled = true;
			txtPath.Enabled = true;
			displayRoad = false;
			readyEdges = false;
			readyPoint = false;
			txtLog.Text = "";
			//
			initMatrix();

			panel_graphic.Refresh();

		}

		/*	private void panel_graphic_Paint_1(object sender, PaintEventArgs e)
			{

			}
			*/

	}
}
