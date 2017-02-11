using System;
using EnvDTE;

namespace Microsoft.VisualStudio.Context
{
    /// <summary>
    /// Context for when an object could be a <see cref="EnvDTE.Project"/> or <see cref="EnvDTE.ProjectItem"/>.
    /// This is most applicable when discovering the current user's selected item in Visual Studio. 
    /// </summary>
    public struct ProjectItemOrProject : IEquatable<ProjectItemOrProject>
    {
        private ProjectItemOrProject(SelectedItem item)
        {
            Project = item.Project;
            ProjectItem = item.ProjectItem;
        }

        public static ProjectItemOrProject From(SelectedItem selectedItem)
        {
            return new ProjectItemOrProject(selectedItem);
        }

        public bool IsProject
        {
            get
            {
                return ProjectItem == null;
            }
        }

        public bool IsProjectItem
        {
            get
            {
                return Project == null;
            }
        }

        public Project Project
        {
            get;
        }

        public ProjectItem ProjectItem
        {
            get;
        }

        public ProjectItem AsProjectItem()
        {
            return Project != null ? null : ProjectItem;
        }

        public Project AsProject()
        {
            return ProjectItem != null ? null : Project;
        }

        internal ProjectItemOrProject(ProjectItem projectItem = null)
        {
            ProjectItem = projectItem;
            Project = null;
        }
        internal ProjectItemOrProject(Project project = null)
        {
            ProjectItem = null;
            Project = project;
        }
        public ProjectItem ToProjectItem(ProjectItemOrProject projectItemOrProject)
        {
            return projectItemOrProject.AsProjectItem();
        }

        public bool Equals(ProjectItemOrProject other)
        {
            return Equals(Project, other.Project) && Equals(ProjectItem, other.ProjectItem) && IsProject == other.IsProject && IsProjectItem == other.IsProjectItem;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;

            return obj is ProjectItemOrProject && Equals((ProjectItemOrProject)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Project?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (ProjectItem?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ IsProject.GetHashCode();
                hashCode = (hashCode * 397) ^ IsProjectItem.GetHashCode();
                return hashCode;
            }
        }
    }
}