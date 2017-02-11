// ----------------------------------------------------------------------------
//  <copyright file="RoslynAndEnvDTEProject.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    internal struct RoslynAndEnvDTEProject : IEquatable<RoslynAndEnvDTEProject>
    {
        public bool Equals(RoslynAndEnvDTEProject other)
        {
            return Equals(RoslynProject, other.RoslynProject) && Equals(EnvDTEProject, other.EnvDTEProject);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is RoslynAndEnvDTEProject && Equals((RoslynAndEnvDTEProject) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((RoslynProject?.GetHashCode() ?? 0) * 397) ^ (EnvDTEProject?.GetHashCode() ?? 0);
            }
        }

        /// <summary>Returns a value that indicates whether the values of two <see cref="T:Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services.RoslynAndEnvDTEProject" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(RoslynAndEnvDTEProject left, RoslynAndEnvDTEProject right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns a value that indicates whether two <see cref="T:Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services.RoslynAndEnvDTEProject" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(RoslynAndEnvDTEProject left, RoslynAndEnvDTEProject right)
        {
            return !left.Equals(right);
        }

        public RoslynAndEnvDTEProject(Project roslynProject)
        {
            RoslynProject = roslynProject;
            EnvDTEProject = EquivalencyProvider.GetEquivalent(roslynProject);
        }

        public RoslynAndEnvDTEProject(Project roslynProject, EnvDTE.Project envDTEProject) : this()
        {
            RoslynProject = roslynProject;
            EnvDTEProject = envDTEProject;
        }

        public Project RoslynProject { get; }

        public EnvDTE.Project EnvDTEProject { get; }

        public static implicit operator Project(RoslynAndEnvDTEProject o)
        {
            return o.RoslynProject;
        }
    }
}