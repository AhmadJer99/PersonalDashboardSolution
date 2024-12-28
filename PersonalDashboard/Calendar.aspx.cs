using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PersonalDashboard.Models;

namespace PersonalDashboard
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Caption = "Tasks Calender";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(150);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
            Calendar1.DayStyle.BackColor = System.Drawing.Color.White;
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.Cyan;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            using (var scope = Global.ServiceProvider.CreateScope())

            using (var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>()) // Replace with your actual DbContext
            {
                var task = context.Tasks.FirstOrDefault(t => t.DueDate.Date == selectedDate.Date);

                if (task != null)
                {
                    TaskDueLabel.Text = $"Task: {task.Title}<br>Description: {task.Description}<br>Priority: {task.Priority}";
                }
                else
                {
                    TaskDueLabel.Text = "No tasks due on this date.";
                }
            }
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            LabelAction.Text = "Month changed to: " + e.NewDate.ToShortDateString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime currentDate = e.Day.Date;
            using (var scope = Global.ServiceProvider.CreateScope())

            using (var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>()) // Replace with your actual DbContext
            {
                var task = context.Tasks.FirstOrDefault(t => t.DueDate.Date == currentDate);

                if (task != null)
                {

                    e.Cell.BackColor = System.Drawing.Color.DarkRed;
                    e.Cell.ForeColor = System.Drawing.Color.White;
                    e.Cell.Font.Bold = true;

                    // Optionally, you can also add a tooltip or a label to indicate there's a task due on this day
                    Literal literal = new Literal();
                    literal.Text = "<br>Task Due"; // Customize as needed
                    
                    e.Cell.Controls.Add(literal);
                }
            }
        }
    }
}
