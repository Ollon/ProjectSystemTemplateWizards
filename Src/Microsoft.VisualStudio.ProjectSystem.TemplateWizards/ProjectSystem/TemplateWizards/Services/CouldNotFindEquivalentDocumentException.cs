using System;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public class CouldNotFindEquivalentDocumentException : Exception
    {
        public CouldNotFindEquivalentDocumentException(string projectItemName)
            :base(projectItemName)
        {
        }
    }
}