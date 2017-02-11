using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public interface IMetadataReferenceService
    {
        void EnsureReferences(ThreadedWaitDialogProgressScope scope, ReferencesOption option, Project project);
        void EnsureReferences(ThreadedWaitDialogProgressScope scope, ReferencesOption option, EnvDTE.Project project);
    }
}