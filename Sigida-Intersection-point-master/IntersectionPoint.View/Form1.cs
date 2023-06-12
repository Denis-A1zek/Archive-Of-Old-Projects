using IntersactionPont.MathLogic;
using IntersactionPont.MathLogic.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IntersectionPoint.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

 

        public void Generate()
        {
            chartFunction.Series.Clear();
            chartFunction.Series.Add(SeriesCreator.CreateLine("Line 1", new Vector2(float.Parse(valueLine1Point1X.Text), float.Parse(valueLine1Point1Y.Text)),
                                       new Vector2(float.Parse(valueLine1Point2X.Text), float.Parse(valueLine1Point2Y.Text))));

            chartFunction.Update();
        }

        private void SecondLineDataChanged(object sender, EventArgs e)
        {
            
            chartFunction.Series.Add(SeriesCreator.CreateLine("Line 2", new Vector2(float.Parse(valueLine2Point1X.Text), float.Parse(valueLine2Point1Y.Text)),
                                       new Vector2(float.Parse(valueLine2Point2X.Text), float.Parse(valueLine2Point2Y.Text))));
            chartFunction.Update();
        }


        private void button_FindCross_Click(object sender, EventArgs e)
        {

            GenerateFirstLine();
            GenerateSecondLine();
            GenerateCrossPoint();
            

        }

        private void GenerateFirstLine()
        {
            chartFunction.Series.Clear();

            //Все используемые textBox для первой линии
            var valuepointString = new string[] { valueLine1Point1X.Text, valueLine1Point1Y.Text, valueLine1Point2X.Text, valueLine1Point2Y.Text };
            var listFloatValuePoint = new List<float>();

            //Парсим все значения
            foreach (var item in valuepointString)
            {
                listFloatValuePoint.Add(StringParser.StringParser.Parse(item));
            }

            //Записываем считываемые точки
            Vector2 point1 = new Vector2(listFloatValuePoint[0], listFloatValuePoint[1]);
            Vector2 point2 = new Vector2(listFloatValuePoint[2], listFloatValuePoint[3]);

            Line line = new Line(point1, point2);

            var strLine = new StraightLine(line);

            chartFunction.Series.Add(
                                 SeriesCreator.CreateLine("Line1",
                                                          strLine.FindPointY(point1.X + 10), strLine.FindPointY(-point1.X + (-10))));
         

            chartFunction.Update();
        }

        private void GenerateSecondLine()
        {

            //Все используемые textBox для первой линии
            var valuepointString = new string[] { valueLine2Point1X.Text, valueLine2Point1Y.Text, valueLine2Point2X.Text, valueLine2Point2Y.Text };
            var listFloatValuePoint = new List<float>();

            //Парсим все значения
            foreach (var item in valuepointString)
            {
                listFloatValuePoint.Add(StringParser.StringParser.Parse(item));
            }

            //Записываем считываемые точки
            Vector2 point1 = new Vector2(listFloatValuePoint[0], listFloatValuePoint[1]);
            Vector2 point2 = new Vector2(listFloatValuePoint[2], listFloatValuePoint[3]);

            Line line = new Line(point1, point2);

            var strLine = new StraightLine(line);

            chartFunction.Series.Add(
                                 SeriesCreator.CreateLine("Line2",
                                                          strLine.FindPointY(point1.X + 10), strLine.FindPointY(-point1.X + (-10))));


            chartFunction.Update();
        }

        private void GenerateCrossPoint()
        {
            var line1 = new Line(new Vector2(float.Parse(valueLine1Point1X.Text), float.Parse(valueLine1Point1Y.Text)),
                                new Vector2(float.Parse(valueLine1Point2X.Text), float.Parse(valueLine1Point2Y.Text)));
            var line2 = new Line(new Vector2(float.Parse(valueLine2Point1X.Text), float.Parse(valueLine2Point1Y.Text)),
                                 new Vector2(float.Parse(valueLine2Point2X.Text), float.Parse(valueLine2Point2Y.Text)));

            var intersaction = new IntersectionsPoint(line1, line2);
            var crossPoint = intersaction.Find();

            if (crossPoint.IsSuccessfully)
                chartFunction.Series.Add(SeriesCreator.CreateDot(new Vector2(crossPoint.Result.X, crossPoint.Result.Y)));
        }
    }


}
