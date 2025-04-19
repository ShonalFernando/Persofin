using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersofinDesktop.View.UserControls
{
    /// <summary>
    /// Interaction logic for GanntChart.xaml
    /// </summary>
    public partial class GanntChart : UserControl
    {
        private double ZoomScale;
        private double TotalWidth; // or base it on available width if needed
        private bool isFirstTime = true;

        public GanntChart()
        {
            InitializeComponent();
            RenderTimeline();
            TotalWidth = 1000;
            ZoomScale = 5;

            Loaded += GanntChart_Loaded;
        }

        private void GanntChart_Loaded(object sender, RoutedEventArgs e)
        {
            RenderTimeline();
            RenderTasks();
        }

        public static readonly DependencyProperty TasksProperty =
        DependencyProperty.Register("Tasks", typeof(List<ProjectTask>), typeof(GanntChart),
            new PropertyMetadata(null, OnTasksChanged));

        public List<ProjectTask> Tasks
        {
            get => (List<ProjectTask>)GetValue(TasksProperty);
            set => SetValue(TasksProperty, value);
        }

        public static readonly DependencyProperty ProjectStartDateProperty =
            DependencyProperty.Register("ProjectStartDate", typeof(DateTime), typeof(GanntChart),
                new PropertyMetadata(DateTime.Today));

        public static readonly DependencyProperty ProjectEndDateProperty =
            DependencyProperty.Register("ProjectEndDate", typeof(DateTime), typeof(GanntChart),
                new PropertyMetadata(DateTime.Today));

        public DateTime ProjectStartDate
        {
            get => (DateTime)GetValue(ProjectStartDateProperty);
            set => SetValue(ProjectStartDateProperty, value);
        }

        public DateTime ProjectEndDate
        {
            get => (DateTime)GetValue(ProjectEndDateProperty);
            set => SetValue(ProjectEndDateProperty, value);
        }

        public static readonly DependencyProperty SelectedTaskProperty =
            DependencyProperty.Register("SelectedTask", typeof(ProjectTask), typeof(GanntChart), new PropertyMetadata(null));

        public ProjectTask SelectedTask
        {
            get => (ProjectTask)GetValue(SelectedTaskProperty);
            set => SetValue(SelectedTaskProperty, value);
        }

        private static void OnTasksChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is GanntChart control)
            {
                //control.RenderTasks();
            }
        }
        private void RenderTimeline()
        {
            DateHeader.Children.Clear(); // Clear existing headers if any

            var totalDays = (ProjectEndDate - ProjectStartDate).Days + 1;
            //double TotalWidth = 1000.0; // Same as task rendering
            double dayWidth = TotalWidth / totalDays;

            for (int i = 0; i < totalDays; i++)
            {
                var date = ProjectStartDate.AddDays(i);
                var dateBlock = new TextBlock
                {
                    Text = date.ToString("MMM dd"),
                    Width = dayWidth,
                    TextAlignment = TextAlignment.Center,
                    FontSize = 10,
                    Margin = new Thickness(1),
                };

                var border = new Border
                {
                    BorderBrush = Brushes.Gray,
                    BorderThickness = new Thickness(0, 0, 1, 0),
                    Child = dateBlock
                };

                DateHeader.Children.Add(border);
            }

            isFirstTime = false;
        }


        private void RenderTasks()
        {
            TaskRows.Children.Clear();

            var totalDays = (ProjectEndDate - ProjectStartDate).Days + 1;
            //double TotalWidth = 1000.0; // or dynamic with ActualWidth
            double dayWidth = TotalWidth / totalDays;

            foreach (var task in Tasks)
            {
                var row = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(2) };

                int startOffset = (task.StartDate - ProjectStartDate).Days;
                int duration = (task.DueDate - task.StartDate).Days + 1;

                var leftSpacer = new Border { Width = dayWidth * startOffset };
                row.Children.Add(leftSpacer);

                var taskButton = new Button
                {
                    Content = task.Title,
                    Width = dayWidth * duration,
                    Background = task.IsCompleted ? Brushes.Green : Brushes.SteelBlue,
                    Foreground = Brushes.WhiteSmoke,
                    ToolTip = $"{task.StartDate:MMM dd} - {task.DueDate:MMM dd}",
                    Tag = task
                };

                taskButton.Click += (s, e) =>
                {
                    if (s is Button btn && btn.Tag is ProjectTask clickedTask)
                    {
                        SelectedTask = clickedTask;
                        // Optional: Visual feedback
                        Debug.WriteLine($"Selected Task: {clickedTask.Title}");
                        //MessageBox.Show($"Selected Task: {clickedTask.Title}");
                    }
                };

                row.Children.Add(taskButton);
                TaskRows.Children.Add(row);
            }

            //MessageBox.Show($"{TotalWidth}");
        }



        private void ZoomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!isFirstTime)
            {
                //MessageBox.Show($"{ZoomScale*TotalWidth}");
                ZoomScale = ZoomSlider?.Value ?? 5;
                TotalWidth = ZoomScale * 100;
                RenderTimeline();
                RenderTasks();
            }
        }
    }
}
