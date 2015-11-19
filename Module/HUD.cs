using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace MultiWiiWinGUI.Module
{
    public class HUD
    {
       
        public static float Airspeed
        {
            get
            {
                return airspeed;
            }
            set
            {
                airspeed = value;
            }
        }

        public static float Altitude
        {
            get
            {
                return altitude;
            }
            set
            {
                altitude = value;
            }
        }

        public static float Heading
        {
            get
            {
                return heading;
            }
            set
            {
                heading = value;
            }
        }

        public static float Pitch
        {
            get
            {
                return pitch;
            }
            set
            {
                pitch = value;
            }
        }
        public static float Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
            }
        }



        private static float heading = 0f;

        private static float pitch = 0f;

        private static float roll = 0f;

        private static float altitude = 0f;

        private static float airspeed = 0f;

        private static Pen linePen = new Pen(Color.FromArgb(60, Color.Red));

        private static SolidBrush textBrush = new SolidBrush(Color.FromArgb(100, Color.GreenYellow));

        private static SolidBrush textBackgroundBrush = new SolidBrush(Color.FromArgb(40, Color.Black));

        private static SolidBrush alphaBrush = new SolidBrush(Color.FromArgb(20, Color.ForestGreen));


      

       
       
        /// <summary>
        /// 绘制俯仰标尺
        /// </summary>
        /// <param name="g"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="pitch"></param>
        /// <param name="roll"></param>
        public static void DrawHorizon(Graphics g, int width, int height, float pitch, float roll)
        {
            int test = width / 2;
            int test2 = height/2;
            int i;
            int num;
            int num1;
            int num2 = (int)Math.Sqrt(Math.Pow((double)width, 2) + Math.Pow((double)height, 2));
            Matrix matrix = new Matrix(1f, 0f, 0f, 1f, 0f, 0f);
            matrix.Translate((float)(width / 2), (float)(height / 2));
            matrix.Rotate(roll);
            int num3 = 10;
            int num4 = (int)(pitch * (float)num3);
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rectangle1 = new Rectangle(-num2 / 2, -num2, test + 2 * num2, (test2 + 2 * num2) / 2 + num4);
            graphicsPath.AddRectangle(rectangle1);
            graphicsPath.Transform(matrix);

            graphicsPath = new GraphicsPath();
            Rectangle rectangle3 = new Rectangle(-num2 / 2, num4, test + 2 * num2, (test2 + 2 * num2) / 2 - num4);
            graphicsPath.AddRectangle(rectangle3);
            graphicsPath.Transform(matrix);


            Pen penCenter = new Pen(Color.FromArgb(50, Color.White));
            penCenter.Width = 2;
            graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(-11, num4, -test / 2, num4);
            graphicsPath.Transform(matrix);
            g.DrawPath(penCenter, graphicsPath);
            graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(test / 2, num4, 11, num4);
            graphicsPath.Transform(matrix);
            g.DrawPath(penCenter, graphicsPath);


            Pen penCenter2 = new Pen(Color.FromArgb(50, Color.Red));
            penCenter2.Width = 2;
             graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(5, 0, -5, 0);
            graphicsPath.Transform(matrix);
            g.DrawPath(penCenter2, graphicsPath);

            graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(0, 5, 0, -5);
            graphicsPath.Transform(matrix);
            g.DrawPath(penCenter2, graphicsPath);

            graphicsPath = new GraphicsPath();
            RectangleF rectangleF = new RectangleF();
            //StringFormat stringFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            StringFormat stringFormat = StringFormat.GenericDefault;
            for (i = -180; i <= 180; i = i + 5)
            {
                if (i % 10 != 0)
                {
                    num1 = -i;

                    rectangleF.X = -45f -  (7f * num1.ToString().Length-7f);
                    rectangleF.Y = (float)(i * num3) + (float)num4;
                    rectangleF.Width = 60f;
                    rectangleF.Height = 15f;
                  
                    graphicsPath.AddString(num1.ToString(), new FontFamily("Arial"), 0, 12f, rectangleF, stringFormat);
                    rectangleF.X = 35f;
                    rectangleF.Y = (float)(i * num3) + (float)num4;
                    rectangleF.Width = 60f;
                    rectangleF.Height = 15f;
                    num1 = -i;
                    graphicsPath.AddString(num1.ToString(), new FontFamily("Arial"), 0, 12f, rectangleF, StringFormat.GenericDefault);
                   
                }
                else if (i != 0)
                {
                    num1 = -i;

                    rectangleF.X = -65f - (7f * num1.ToString().Length - 7f);
                    rectangleF.Y = (float)(i * num3) + (float)num4 - 3f;
                    rectangleF.Width = 60f;
                    rectangleF.Height = 15f;
                   
                    graphicsPath.AddString(num1.ToString(), new FontFamily("Arial"), 0, 12f, rectangleF, stringFormat);
                    rectangleF.X = 58f;
                    rectangleF.Y = (float)(i * num3) + (float)num4 - 3f;
                    rectangleF.Width = 60f;
                    rectangleF.Height = 15f;
                    num1 = -i;
                    graphicsPath.AddString(num1.ToString(), new FontFamily("Arial"), 0, 12f, rectangleF, StringFormat.GenericDefault);
                    
                }
               
            }
            graphicsPath.Transform(matrix);
            graphicsPath.FillMode = FillMode.Winding;
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillPath(new SolidBrush(Color.FromArgb(100, Color.Green)), graphicsPath);

            Pen penline = new Pen(Color.FromArgb(40, Color.Yellow));
            penline.Width = 2;
            for (i = -180; i <= 180; i = i + 5)
            {
                if (i % 10 != 0)
                {
                   

                   // pen.DashStyle=DashStyle.Dot;

                    num = i * num3 + num4;
                    graphicsPath = new GraphicsPath();
                    graphicsPath.AddLine(new PointF(-10f, (float)num), new PointF(-35f, (float)num));
                    graphicsPath.AddLine(new PointF(-35f, (float)num), new PointF(-35f, (float)(num + 5)));
                    graphicsPath.Transform(matrix);
                    g.DrawPath(penline, graphicsPath);
                    graphicsPath = new GraphicsPath();
                    graphicsPath.AddLine(new PointF(10f, (float)num), new PointF(35f, (float)num));
                    graphicsPath.AddLine(new PointF(35f, (float)num), new PointF(35f, (float)(num + 5)));
                    graphicsPath.Transform(matrix);
                    g.DrawPath(penline, graphicsPath);
                }
                else if (i != 0)
                {
                    num = i * num3 + num4;
                    graphicsPath = new GraphicsPath();
                    graphicsPath.AddLine(new PointF(-25f, (float)num), new PointF(-55f, (float)num));
                    graphicsPath.AddLine(new PointF(-55f, (float)num), new PointF(-55f, (float)(num + 10)));
                    graphicsPath.Transform(matrix);
                    g.DrawPath(penline, graphicsPath);
                    graphicsPath = new GraphicsPath();
                    graphicsPath.AddLine(new PointF(25f, (float)num), new PointF(55f, (float)num));
                    graphicsPath.AddLine(new PointF(55f, (float)num), new PointF(55f, (float)(num + 10)));
                    graphicsPath.Transform(matrix);
                    g.DrawPath(penline, graphicsPath);
                }
            }
        }
        public  static void DrawSpeedGuage(Graphics g, Point topCorner)
        {
           
            int num = 60;
            int num1 = 300;
            Rectangle rectangle = new Rectangle(topCorner.X, topCorner.Y, num, num1);
            Rectangle rectangle1 = new Rectangle(topCorner.X, topCorner.Y, num - 25, num1);
         
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };
            Font font = MaxTextSize(12, 2, rectangle1, new FontFamily("Arial"), "-800");
            int num2 = (int)airspeed + 25;
            int y = topCorner.Y;
            int num3 = 6;
            for (int i = 0; i <= 50; i++)
            {
                num2--;
                if (num2 % 10 == 0)
                {
                    g.DrawLine(linePen, new PointF((float)(num + topCorner.X), (float)(i * num3 + y)), new PointF((float)(num + topCorner.X - 20), (float)(i * num3 + y)));
                    if ((i <= 0 ? false : i < 50))
                    {
                        g.DrawString(num2.ToString(), font, textBrush, new PointF((float)(num + topCorner.X - 20), (float)(i * num3 + y - font.Height / 2)), stringFormat);
                    }
                }
                else if (num2 % 5 != 0)
                {
                    g.DrawLine(linePen, new PointF((float)(num + topCorner.X), (float)(i * num3 + y)), new PointF((float)(num + topCorner.X - 10), (float)(i * num3 + y)));
                }
                else
                {
                    g.DrawLine(linePen, new PointF((float)(num + topCorner.X), (float)(i * num3 + y)), new PointF((float)(num + topCorner.X - 15), (float)(i * num3 + y)));
                }
            }
            Point[] x = new Point[6];
            int num4 = 30;
            int y1 = topCorner.Y + num1 / 2 - num4 / 2 - num3;
            x[0].X = topCorner.X;
            x[0].Y = y1;
            x[1].X = num + topCorner.X - 15;
            x[1].Y = y1;
            x[2].X = num + topCorner.X;
            x[2].Y = num4 / 2 + y1;
            x[3].X = num + topCorner.X - 15;
            x[3].Y = num4 + y1;
            x[4].X = topCorner.X;
            x[4].Y = num4 + y1;
            x[5].X = topCorner.X;
            x[5].Y = y1;
            g.FillPolygon(textBackgroundBrush, x);
            g.DrawPolygon(linePen, x);
            Font font1 = new Font(new FontFamily("Arial"), 12, GraphicsUnit.Pixel);
            g.DrawString(airspeed.ToString(), font1, Brushes.Red, new PointF((float)(topCorner.X + num - 19), (float)y1+9), stringFormat);
            g.FillRectangle(alphaBrush, rectangle);
            g.DrawRectangle(new Pen(Color.FromArgb(40, Color.White)), rectangle);
        }
        public static void DrawAltitudeGuage(Graphics g, Point topCorner)
        {
            int num = 50;
            int num1 = 300;
            Rectangle rectangle = new Rectangle(topCorner.X, topCorner.Y, num, num1);
            Rectangle rectangle1 = new Rectangle(topCorner.X, topCorner.Y, num - 25, num1);
          
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };
            Font font = MaxTextSize(12, 2, rectangle1, new FontFamily("Arial"), "-800");
            int num2 = (int)altitude + 300;
            int y = topCorner.Y;
            double num3 = 0.5;
            for (int i = 0; i <= 600; i++)
            {
                num2--;
                if (num2 % 100 == 0)
                {
                    g.DrawLine(linePen, new PointF((float)topCorner.X, (float)((int)((double)i * num3) + y)), new PointF((float)(topCorner.X + 20), (float)((int)((double)i * num3) + y)));
                    if ((i > 15 && i < 595))
                    {
                        g.DrawString(num2.ToString(), font, textBrush, new PointF((float)(topCorner.X + 20), (float)((int)((double)i * num3) + y - font.Height / 2)), stringFormat);
                    }
                }
                else if (num2 % 50 == 0)
                {
                    g.DrawLine(linePen, new PointF((float)topCorner.X, (float)((int)((double)i * num3) + y)), new PointF((float)(topCorner.X + 15), (float)((int)((double)i * num3) + y)));
                }
                else if (num2 % 25 == 0)
                {
                    g.DrawLine(linePen, new PointF((float)topCorner.X, (float)((int)((double)i * num3) + y)), new PointF((float)(topCorner.X + 10), (float)((int)((double)i * num3) + y)));
                }
            }
            Point[] x = new Point[6];
            int num4 = 30;
            int y1 = topCorner.Y + num1 / 2 - num4 / 2;
            x[0].X = topCorner.X + num;
            x[0].Y = y1;
            x[1].X = topCorner.X + 15;
            x[1].Y = y1;
            x[2].X = topCorner.X + 1;
            x[2].Y = num4 / 2 + y1;
            x[3].X = topCorner.X + 15;
            x[3].Y = num4 + y1;
            x[4].X = topCorner.X + num;
            x[4].Y = num4 + y1;
            x[5].X = topCorner.X + num;
            x[5].Y = y1;
            g.FillPolygon(textBackgroundBrush, x);
            g.DrawPolygon(linePen, x);
            Font font1 = new Font(new FontFamily("Arial"), 12, GraphicsUnit.Pixel);
            g.DrawString(altitude.ToString(), font1, Brushes.White, new PointF((float)(topCorner.X + 20), (float)y1 + 9), stringFormat);
            g.FillRectangle(alphaBrush, rectangle);
            g.DrawRectangle(new Pen(Color.FromArgb(40, Color.White)), rectangle);
        }
        public static void DrawRollGuage(Graphics g, Point center)
        {
            MaxTextSize(15, 2, new Rectangle(0, 0, 50, 20), new FontFamily("Arial"), "-800");
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            int num = Convert.ToInt16(roll) + 36;
            if (num > 180)
            {
                num = num - 360;
            }
            int num1 = 200;
            int num2 = num1 + 5;
            int num3 = num1 + 7;
            int num4 = num1 + 10;
            int num5 = num1 + 12;
            for (int i = 240; i <= 300; i++)
            {
                num--;
                if (num > 179)
                {
                    num = -180;
                }
                else if (num < -179)
                {
                    num = 180;
                }
                Point point = new Point(0, 0);
                Point y = new Point(0, 0);
                Point x = new Point(0, 0);
                Point point1 = new Point(0, 0);
                Point y1 = new Point(0, 0);
                point.Y = center.Y + (int)Math.Round((double)num1 * Math.Sin((double)i * 3.14159265358979 / 180));
                point.X = center.X + (int)Math.Round((double)num1 * Math.Cos((double)i * 3.14159265358979 / 180));
                y.Y = center.Y + (int)Math.Round((double)num2 * Math.Sin((double)i * 3.14159265358979 / 180));
                y.X = center.X + (int)Math.Round((double)num2 * Math.Cos((double)i * 3.14159265358979 / 180));
                x.Y = center.Y + (int)Math.Round((double)num3 * Math.Sin((double)i * 3.14159265358979 / 180));
                x.X = center.X + (int)Math.Round((double)num3 * Math.Cos((double)i * 3.14159265358979 / 180));
                point1.Y = center.Y + (int)Math.Round((double)num4 * Math.Sin((double)i * 3.14159265358979 / 180));
                point1.X = center.X + (int)Math.Round((double)num4 * Math.Cos((double)i * 3.14159265358979 / 180));
                y1.Y = center.Y + (int)Math.Round((double)num5 * Math.Sin((double)i * 3.14159265358979 / 180));
                y1.X = center.X + (int)Math.Round((double)num5 * Math.Cos((double)i * 3.14159265358979 / 180));
                if (num % 10 == 0)
                {
                    g.DrawLine(linePen, point, point1);
                }
                else if (num % 5 == 0)
                {
                    g.DrawLine(linePen, point, x);
                }
            }
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Point[] pointArray = new Point[8];
            int num6 = -20;
            int num7 = 30;
            int num8 = 25;
            int x1 = center.X - num7 / 2;
            int y2 = center.Y - num8 / 2 - num1 - num6;
            int num9 = 10;
            pointArray[0].X = x1;
            pointArray[0].Y = y2;
            pointArray[1].X = x1 + num9;
            pointArray[1].Y = y2;
            pointArray[2].X = x1 + num7 / 2;
            pointArray[2].Y = center.Y - num1;
            pointArray[3].X = x1 + num7 - num9;
            pointArray[3].Y = y2;
            pointArray[4].X = x1 + num7;
            pointArray[4].Y = y2;
            pointArray[5].X = x1 + num7;
            pointArray[5].Y = y2 + num8;
            pointArray[6].X = x1;
            pointArray[6].Y = y2 + num8;
            pointArray[7].X = x1;
            pointArray[7].Y = y2;
            g.FillPolygon(textBackgroundBrush, pointArray);
            g.DrawPolygon(linePen, pointArray);
            if (roll > 180f)
            {
                roll = roll - 360f;
            }
            Font font = new Font(new FontFamily("Arial"), 12, GraphicsUnit.Pixel);
            g.DrawString(roll.ToString(), font, Brushes.White, new PointF((float)center.X, (float)(center.Y - num1 - num6)), stringFormat);
        }
     public static void DrawCompass(Graphics g, Point center)
        {
            int num =70;
            int num2 = num - 5;
            int num3 = num - 10;
            int num4 = num - 15;
            int num5 = num - 28;
            Font font = MaxTextSize(12, 2, new Rectangle(0, 0, 40, 20), new FontFamily("Arial"), "-800");
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.FillEllipse(alphaBrush, center.X - num, center.Y - num, 2 * num, 2 * num);
            g.DrawEllipse(linePen, center.X - num, center.Y - num, 2 * num, 2 * num);
            int num6 = (int)heading - 90;
            for (int i = 0; i <= 359; i++)
            {
                num6--;
                if (num6 < 0)
                {
                    num6 = 360 + num6;
                }
                else
                {
                    if (num6 >= 360)
                    {
                        num6 -= 360;
                    }
                }
                Point pt = new Point(0, 0);
                Point pt2 = new Point(0, 0);
                Point pt3 = new Point(0, 0);
                Point pt4 = new Point(0, 0);
                Point p = new Point(0, 0);
                pt.Y = center.Y + (int)Math.Round((double)num * Math.Sin((double)i * 3.1415926535897931 / 180.0));
                pt.X = center.X + (int)Math.Round((double)num * Math.Cos((double)i * 3.1415926535897931 / 180.0));
                pt2.Y = center.Y + (int)Math.Round((double)num2 * Math.Sin((double)i * 3.1415926535897931 / 180.0));
                pt2.X = center.X + (int)Math.Round((double)num2 * Math.Cos((double)i * 3.1415926535897931 / 180.0));
                pt3.Y = center.Y + (int)Math.Round((double)num3 * Math.Sin((double)i * 3.1415926535897931 / 180.0));
                pt3.X = center.X + (int)Math.Round((double)num3 * Math.Cos((double)i * 3.1415926535897931 / 180.0));
                pt4.Y = center.Y + (int)Math.Round((double)num4 * Math.Sin((double)i * 3.1415926535897931 / 180.0));
                pt4.X = center.X + (int)Math.Round((double)num4 * Math.Cos((double)i * 3.1415926535897931 / 180.0));
                p.Y = center.Y + (int)Math.Round((double)num5 * Math.Sin((double)i * 3.1415926535897931 / 180.0));
                p.X = center.X + (int)Math.Round((double)num5 * Math.Cos((double)i * 3.1415926535897931 / 180.0));
                if (num6 % 30 == 0)
                {
                    g.DrawLine(linePen, pt, pt4);
                    int num7 = num6;
                    if (num7 <= 135)
                    {
                        if (num7 <= 45)
                        {
                            if (num7 != 0)
                            {
                                if (num7 != 45)
                                {
                                    goto IL_4E0;
                                }
                                g.DrawString("东北", font, textBrush, p, stringFormat);
                            }
                            else
                            {
                                g.DrawString("北", font, textBrush, p, stringFormat);
                            }
                        }
                        else
                        {
                            if (num7 != 90)
                            {
                                if (num7 != 135)
                                {
                                    goto IL_4E0;
                                }
                                g.DrawString("东南", font, textBrush, p, stringFormat);
                            }
                            else
                            {
                                g.DrawString("东", font, textBrush, p, stringFormat);
                            }
                        }
                    }
                    else
                    {
                        if (num7 <= 215)
                        {
                            if (num7 != 180)
                            {
                                if (num7 != 215)
                                {
                                    goto IL_4E0;
                                }
                                g.DrawString("西南", font, textBrush, p, stringFormat);
                            }
                            else
                            {
                                g.DrawString("南", font, textBrush, p, stringFormat);
                            }
                        }
                        else
                        {
                            if (num7 != 225)
                            {
                                if (num7 != 270)
                                {
                                    goto IL_4E0;
                                }
                                g.DrawString("西", font, textBrush, p, stringFormat);
                            }
                            else
                            {
                                g.DrawString("西南", font, textBrush, p, stringFormat);
                            }
                        }
                    }
                    goto IL_54D;
                IL_4E0:
                    g.DrawString(num6.ToString(), font, textBrush, p, stringFormat);
                }
                else
                {
                    if (num6 % 10 == 0)
                    {
                        g.DrawLine(linePen, pt, pt3);
                    }
                    else
                    {
                        if (num6 % 5 == 0)
                        {
                            g.DrawLine(linePen, pt, pt2);
                        }
                    }
                }
            IL_54D: ;
            }
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Point[] array = new Point[8];
            int num8 = -20;
            int num9 = 20;
            int num10 = 25;
            int num11 = center.X - num9 / 2;
            int num12 = center.Y - num10 / 2 - num - num8;
            int num13 = 10;
            array[0].X = num11;
            array[0].Y = num12;
            array[1].X = num11 + num13;
            array[1].Y = num12;
            array[2].X = num11 + num9 / 2;
            array[2].Y = center.Y - num;
            array[3].X = num11 + num9 - num13;
            array[3].Y = num12;
            array[4].X = num11 + num9;
            array[4].Y = num12;
            array[5].X = num11 + num9;
            array[5].Y = num12 + num10;
            array[6].X = num11;
            array[6].Y = num12 + num10;
            array[7].X = num11;
            array[7].Y = num12;
            g.FillPolygon(textBackgroundBrush, array);
            g.DrawPolygon(linePen, array);
            Font font2 = new Font(new FontFamily("Arial"), 12, GraphicsUnit.Pixel);
            g.DrawString(heading.ToString(), font2, Brushes.White, new PointF((float)center.X, (float)(center.Y - num - num8)), stringFormat);
        }


        private static Font MaxTextSize(int start_size, int min_size, Rectangle MaxRec, FontFamily fontfamily, string text)
        {
            Font font;
            Bitmap bitmap = new Bitmap(100, 100);
            Graphics graphic = Graphics.FromImage(bitmap);
            Font font1 = new Font(fontfamily, (float)min_size, GraphicsUnit.Pixel);
            int startSize = start_size;
            while (true)
            {
                if (startSize > min_size)
                {
                    font1 = new Font(fontfamily, (float)startSize, GraphicsUnit.Pixel);
                    SizeF sizeF = graphic.MeasureString(text, font1);
                    if ((sizeF.Width >= (float)MaxRec.Width ? true : sizeF.Height >= (float)MaxRec.Height))
                    {
                        startSize--;
                    }
                    else
                    {
                        graphic.Dispose();
                        bitmap.Dispose();
                        font = font1;
                        break;
                    }
                }
                else
                {
                    graphic.Dispose();
                    bitmap.Dispose();
                    font = font1;
                    break;
                }
            }
            return font;
        }

    }
}
