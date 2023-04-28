using System;
using System.Windows.Input;
using Xamarin.Forms;
using XCalendar.Core.Models;

namespace NewTCEApp.ViewModels
{
    internal class CalendarViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

        public ICommand NavigateCalendarCommand { get; set; }
        public CalendarViewModel()
        {
            NavigateCalendarCommand = new Command<int>(NavigateCalendar);
        }

        public void NavigateCalendar(int amount)
        {
            DateTime targetDateTime = MyCalendar.NavigatedDate.AddMonths(amount);

            MyCalendar.Navigate(targetDateTime - MyCalendar.NavigatedDate);
            
        }
    }
}
