// ----------------------------------------------------------------------------
//  <copyright file="$itemrootname$.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Immutable;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.ProjectSystem;
using Microsoft.VisualStudio.ProjectSystem.Build;

namespace NamespaceNameHere
{
    [ExportBuildGlobalPropertiesProvider]
    [AppliesTo(ProjectCapabilities.AlwaysApplicable)]
    internal class ClassNameHere : StaticGlobalPropertiesProviderBase
    {
        private IProjectService _projectService;

        private static readonly Task<IImmutableDictionary<string, string>> BuildProperties =
            Task.FromResult((IImmutableDictionary<string, string>)Empty.PropertiesMap);


        [ImportingConstructor]
        public ClassNameHere(IProjectService projectService) : base(projectService.Services)
        {
            _projectService = projectService;
        }

        public override Task<IImmutableDictionary<string, string>> GetGlobalPropertiesAsync(CancellationToken cancellationToken)
        {
            return BuildProperties;
        }
    }
}
