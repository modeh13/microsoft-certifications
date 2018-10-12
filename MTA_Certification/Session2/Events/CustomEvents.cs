using System;

namespace Session2.Events
{
   public class CustomEvents
   {
      public delegate void DelegateText(string text); //Delegate to manages the EventHandlers
      public delegate void MyEvent(CustomEventArgs e);

      //Using delegates with Event
      public event DelegateText SetMessage; //using "event" keyword
      public DelegateText SetText;  //We can skip the use "event" keyword

      //Using EventHanler delegate defined in the .NET Framework. Delegate signature (object sender, EventArgs e)
      public event EventHandler EventHandler;
      public EventHandler PredefinedEventHandler;
   }

   //Custom class to manages EventArgs for the Event Handlers. (Data of the Event)
   public class CustomEventArgs : EventArgs
   {
      public int ErrorCode { get; set; }
   }
}