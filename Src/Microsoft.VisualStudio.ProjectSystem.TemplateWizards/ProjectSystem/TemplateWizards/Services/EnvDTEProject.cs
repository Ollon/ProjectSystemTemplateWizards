// ----------------------------------------------------------------------------
//  <copyright file="EnvDTEProject.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.ProjectSystem.Utilities;
using VSLangProj;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public sealed class EnvDTEProject : Project
    {
        private readonly Project _project;

        public static EnvDTEProject From(Project project)
        {
            return new EnvDTEProject(project);
        }

        public VSProject AsVSProject()
        {
            return Object as VSProject;
        }

        public IEnumerable<Reference> References
        {
            get
            {
                foreach (Reference reference in AsVSProject().References)
                {
                    yield return reference;
                }
            }
        }

        public IEnumerable<ProjectItem> Folders
        {
            get
            {
                foreach (ProjectItem projectItem in AllProjectItems)
                {
                    if (projectItem.Kind == ItemTypeGuids.PhysicalFolder)
                    {
                        yield return projectItem;
                    }
                }
            }
        }

        public IEnumerable<ProjectItem> AllProjectItems
        {
            get
            {
                return _project.GetAllProjectItems();
            }
        }

        private EnvDTEProject(Project project)
        {
            _project = project;
        }

        public void SaveAs(string NewFileName)
        {
            _project.SaveAs(NewFileName);
        }

        public void Save(string fileName = "")
        {
            _project.Save(fileName);
        }

        public void Delete()
        {
            _project.Delete();
        }

        public string Name
        {
            get
            {
                return _project.Name;
            }
            set
            {
                _project.Name = value;
            }
        }

        public string FileName
        {
            get
            {
                return _project.FileName;
            }
        }

        public bool IsDirty
        {
            get
            {
                return _project.IsDirty;
            }
            set
            {
                _project.IsDirty = value;
            }
        }

        public EnvDTE.Projects Collection
        {
            get
            {
                return _project.Collection;
            }
        }

        public DTE DTE
        {
            get
            {
                return _project.DTE;
            }
        }

        public string Kind
        {
            get
            {
                return _project.Kind;
            }
        }

        public ProjectItems ProjectItems
        {
            get
            {
                return _project.ProjectItems;
            }
        }

        public Properties Properties
        {
            get
            {
                return _project.Properties;
            }
        }

        public string UniqueName
        {
            get
            {
                return _project.UniqueName;
            }
        }

        public object Object
        {
            get
            {
                return _project.Object;
            }
        }

        public object get_Extender(string ExtenderName)
        {
            return _project.Extender[ExtenderName];
        }

        public object ExtenderNames
        {
            get
            {
                return _project.ExtenderNames;
            }
        }

        public string ExtenderCATID
        {
            get
            {
                return _project.ExtenderCATID;
            }
        }

        public string FullName
        {
            get
            {
                return _project.FullName;
            }
        }

        public bool Saved
        {
            get
            {
                return _project.Saved;
            }
            set
            {
                _project.Saved = value;
            }
        }

        public ConfigurationManager ConfigurationManager
        {
            get
            {
                return _project.ConfigurationManager;
            }
        }

        public Globals Globals
        {
            get
            {
                return _project.Globals;
            }
        }

        public ProjectItem ParentProjectItem
        {
            get
            {
                return _project.ParentProjectItem;
            }
        }

        public CodeModel CodeModel
        {
            get
            {
                return _project.CodeModel;
            }
        }

        public Project Project => _project;
    }
}