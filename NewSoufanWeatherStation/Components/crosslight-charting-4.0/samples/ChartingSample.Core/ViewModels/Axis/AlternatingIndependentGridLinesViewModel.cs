﻿using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AlternatingIndependentGridLinesViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsAlternating = true; o.AlternatingRowColor = Colors.LightGray; });

            this.Chart.IndependentAxis = independentAxis;
        }

        #endregion
    }
}