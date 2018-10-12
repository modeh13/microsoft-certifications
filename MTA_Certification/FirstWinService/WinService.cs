using System.Diagnostics;
using System.ServiceProcess;

namespace FirstWinService
{
   //WINDOW SERVICES
   //All Window services application need to inherit of the base class "ServiceBase".
   public partial class WinService : ServiceBase
   {
      public WinService()
      {
         InitializeComponent();

         if (!EventLog.SourceExists("WinService"))
         {
            EventLog.CreateEventSource("WinService", "Application");
         }
      }

      protected override void OnStart(string[] args)
      {
         eventLogService.WriteEntry("Begining WinService", EventLogEntryType.Information, 1001);
      }

      protected override void OnPause()
      {
         base.OnPause();
         eventLogService.WriteEntry("Pausing WinService", EventLogEntryType.Information, 1001);
      }

      protected override void OnStop()
      {
         eventLogService.WriteEntry("Stopping WinService", EventLogEntryType.Information, 1001);
      }

      protected override void OnContinue()
      {
         base.OnContinue();
         eventLogService.WriteEntry("Continuing WinService", EventLogEntryType.Information, 1001);
      }

      protected override void OnShutdown()
      {
         base.OnShutdown();
         eventLogService.WriteEntry("Shutdowning WinService", EventLogEntryType.Information, 1001);
      }
   }
}