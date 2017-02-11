using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;


public struct ThreadedWaitDialogProgressScope : IDisposable
{
    public ThreadedWaitDialogProgressScope(string waitCaption)
    {
        IVsThreadedWaitDialogFactory factory =
            (IVsThreadedWaitDialogFactory)Package.GetGlobalService(typeof(SVsThreadedWaitDialogFactory));
        Session = factory.StartWaitDialog(waitCaption);
    }

    public void Update(string waitMessage, string progressText, string statusBarText, bool isCancelable, int currentStep, int totalSteps)
    {
        Session.Progress.Report(new ThreadedWaitDialogProgressData(waitMessage, progressText, statusBarText, isCancelable, currentStep, totalSteps));
    }

    public void Update(string waitMessage, string progressText = null, string statusBarText = null, bool isCancelable = false)
    {
        Session.Progress.Report(new ThreadedWaitDialogProgressData(waitMessage, progressText, statusBarText, isCancelable));
    }

    public void Update(ThreadedWaitDialogProgressData data)
    {
        Session.Progress.Report(data);
    }

    public ThreadedWaitDialogHelper.Session Session { get; }
    public void Dispose()
    {
        Session.Dispose();
    }
}
