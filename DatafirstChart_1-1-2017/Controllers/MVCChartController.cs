using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using DatafirstChart_1_1_2017.Models;
using WebGrease.Css.Extensions;

namespace DatafirstChart_1_1_2017.Controllers
{
    public class MVCChartController : Controller
    {
        //
        // GET: /MVCChart/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CharterColumn()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx=> xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx=>yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Column Chart]")
                .AddSeries("default", chartType: "Column", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult ChartBar()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Bar Chart]")
                .AddSeries("default", chartType: "Bar", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult ChartPie()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Pie Chart]")
                .AddSeries("default", chartType: "Pie", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult ChartThreeLineBreak()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Three Line Chart]")
                .AddSeries("default", chartType: "Candlestick", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult ChartBubble()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Bubble Chart]")
                .AddSeries("default", chartType: "Bubble", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult DoughnutChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Doughnut Chart]")
                .AddSeries("default", chartType: "Doughnut", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult StackedBar100()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Stacked Bar Chart]")
                .AddSeries("default", chartType: "StackedBar100", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult BoxPlotChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [BoxPlot Chart]")
                .AddSeries("default", chartType: "BoxPlot", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult PyramidChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Pyramid Chart]")
                .AddSeries("default", chartType: "Pyramid", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult PolarChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Polar Chart]")
                .AddSeries("default", chartType: "Polar", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult RadarChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Radar Chart]")
                .AddSeries("default", chartType: "Radar", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult RangeBarChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Rangebar Chart]")
                .AddSeries("default", chartType: "Rangebar", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult FunnelChart()
        {
            var _context = new ChartEntities3();
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();
            var results = from p in _context.Chart2 select p;
            results.ToList().ForEach(rx => xValue.Add(rx.Growth_Year));
            results.ToList().ForEach(rx => yValue.Add(rx.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Chart for Growth [Funnel Chart]")
                .AddSeries("default", chartType: "Funnel", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }
	}
}