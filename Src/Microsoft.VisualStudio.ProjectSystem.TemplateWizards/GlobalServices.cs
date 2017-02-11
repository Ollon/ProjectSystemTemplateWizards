using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.LanguageServices;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using NuGet.VisualStudio;

namespace Microsoft.VisualStudio
{
    internal static class GlobalServices
    {
        public static TServiceInterface GetService<TService, TServiceInterface>()
        {
            return (TServiceInterface)Package.GetGlobalService(typeof(TService));
        }

        public static TServiceInterface GetComponentModelService<TServiceInterface>() where TServiceInterface : class
        {
            return ComponentModel.GetService<TServiceInterface>();
        }

        public static IComponentModel ComponentModel
        {
            get { return GetService<SComponentModel, IComponentModel>(); }
        }

        public static IVsPackageSourceProvider PackageSourceProvider
        {
            get { return ComponentModel.GetService<IVsPackageSourceProvider>(); }
        }

        public static IVsPackageManagerProvider PackageManagerProvider
        {
            get { return ComponentModel.GetService<IVsPackageManagerProvider>(); }
        }

        public static IVsPackageInstaller2 PackageInstaller2
        {
            get { return ComponentModel.GetService<IVsPackageInstaller2>(); }
        }

        public static IVsPackageInstallerServices InstallerServices
        {
            get { return ComponentModel.GetService<IVsPackageInstallerServices>(); }
        }
        public static IVsFindSymbol FindSymbol
        {
            get { return GetService<SVsObjectSearch, IVsFindSymbol>(); }
        }

        public static IVsSolutionBuildManager SolutionBuildManager
        {
            get { return GetService<SVsSolutionBuildManager, IVsSolutionBuildManager>(); }
        }

        public static IVsSolution Solution
        {
            get { return GetService<SVsSolution, IVsSolution>(); }
        }

        public static IVsSolution4 Solution4
        {
            get { return GetService<SVsSolution, IVsSolution4>(); }
        }

        public static IVsSolutionPersistence SolutionPersistence
        {
            get { return GetService<SVsSolutionPersistence, IVsSolutionPersistence>(); }
        }

        public static IVsShell Shell
        {
            get { return GetService<SVsShell, IVsShell>(); }
        }

        public static IVsShell4 Shell4
        {
            get { return GetService<SVsShell, IVsShell4>(); }
        }

        public static IVsShell5 Shell5
        {
            get { return GetService<SVsShell, IVsShell5>(); }
        }

        public static IVsUIShell UIShell
        {
            get { return GetService<SVsUIShell, IVsUIShell>(); }
        }

        public static IVsUIShell5 UIShell5
        {
            get { return GetService<SVsUIShell, IVsUIShell5>(); }
        }

        public static DTE DTE
        {
            get { return GetService<SDTE, DTE>(); }
        }

        public static DTE2 DTE2
        {
            get { return GetService<SDTE, DTE2>(); }
        }

        public static IVsRunningDocumentTable RDT
        {
            get { return GetService<SVsRunningDocumentTable, IVsRunningDocumentTable>(); }
        }

        public static IVsMonitorSelection MonitorSelection
        {
            get { return GetService<SVsShellMonitorSelection, IVsMonitorSelection>(); }
        }

        public static IVsMonitorUserContext MonitorUserContext
        {
            get { return GetService<SVsMonitorUserContext, IVsMonitorUserContext>(); }
        }

        public static IVsObjectManager2 ObjectManager
        {
            get { return GetService<SVsObjectManager, IVsObjectManager2>(); }
        }

        public static IOleComponentManager ComponentManager
        {
            get { return GetService<SOleComponentManager, IOleComponentManager>(); }
        }

        public static IVsSettingsManager SettingsManager
        {
            get { return GetService<SVsSettingsManager, IVsSettingsManager>(); }
        }

        public static IVsResourceManager ResourceManager
        {
            get { return GetService<SVsResourceManager, IVsResourceManager>(); }
        }

        public static IVsSccManagerTooltip SccManagerTootip
        {
            get { return GetService<SVsSccManager, IVsSccManagerTooltip>(); }
        }

        public static IVsUIShellOpenDocument3 ShellOpenDocument3
        {
            get { return GetService<SVsUIShellOpenDocument, IVsUIShellOpenDocument3>(); }
        }

        public static IVsTaskSchedulerService TaskSchedulerService
        {
            get { return GetService<SVsTaskSchedulerService, IVsTaskSchedulerService>(); }
        }

        public static IVsImageService ImageService
        {
            get { return GetService<SVsImageService, IVsImageService>(); }
        }

        public static IVsActivityLog ActivityLog
        {
            get { return GetService<SVsActivityLog, IVsActivityLog>(); }
        }

        public static IVsDataSourceFactory DataSourceFactory
        {
            get { return GetService<SVsDataSourceFactory, IVsDataSourceFactory>(); }
        }

        public static VisualStudioWorkspace VisualStudioWorkspace
        {
            get
            {
                return GetComponentModelService<VisualStudioWorkspace>();
            }
        }

        public static Microsoft.CodeAnalysis.Solution CurrentSolution
        {
            get
            {
                return VisualStudioWorkspace.CurrentSolution;
            }
        }

    }
}
