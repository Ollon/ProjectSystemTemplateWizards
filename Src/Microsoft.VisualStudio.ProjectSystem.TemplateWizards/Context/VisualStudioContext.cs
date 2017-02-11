//-----------------------------------------------------------------------
// <copyright file="VisualStudioContext.cs" company="Ollon, LLC">
//     Copyright (c) Ollon, LLC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Microsoft.VisualStudio.Context
{
    /// <summary>
    /// Provides a way to express a context in visual studio.
    /// </summary>
    public struct VisualStudioContext : IEquatable<VisualStudioContext>
    {
        private readonly VSContext _context;

        [Flags]
        private enum VSContext
        {
            None = 1 << 0,
            ContextMenus = 1 << 1,
            FolderContextMenu = 1 << 2,
            ProjectSolutionContextMenus = 1 << 3,
            Project = 1 << 4,
            SolutionFolder = 1 << 5,
            VisualBasicProject = 1 << 6,
            CSharpProject = 1 << 7,
            CppProject = 1 << 8,
            JSharpProject = 1 << 9,
            WebProject = 1 << 10,
            ProjectContextMenu = 1 << 11,
            SolutionContextMenu = 1 << 12,
            ItemContextMenu = 1 << 13,
            MainBuildMenu = 1 << 14,
            MainToolsMenu = 1 << 15,
            ProjectItem = 1 << 16,
            PhysicalFile = 1 << 17,
            PhysicalFolder = 1 << 18,
            SolutionNode = 1 << 19,
            VirtualFolder = 1 << 20,
            Subproject = 1 << 21,
            CodeWindow = 1 << 22,
            SolutionItem = 1 << 23,
            NETStandardProject = 1 << 24
        }

        private VisualStudioContext(VSContext vSContext)
        {
            _context = vSContext;
        }

        private static VSContext SetFlag(VSContext existing, VSContext context, bool isSet)
        {
            return isSet ? (existing | context) : (existing & ~context);
        }

        public bool IsNone
        {
            get { return (_context & VSContext.None) != 0; }
        }

        public bool IsContextMenus
        {
            get { return (_context & VSContext.ContextMenus) != 0; }
        }

        public bool IsFolderContextMenu
        {
            get { return (_context & VSContext.FolderContextMenu) != 0; }
        }

        public bool IsProjectSolutionContextMenus
        {
            get { return (_context & VSContext.ProjectSolutionContextMenus) != 0; }
        }

        public bool IsProject
        {
            get { return IsCSharpProject || IsJSharpProject || IsWebProject || IsVisualBasicProject || IsCppProject || (_context & VSContext.Project) != 0; }
        }

        public bool IsSolutionFolder
        {
            get { return (_context & VSContext.SolutionFolder) != 0; }
        }

        public bool IsVisualBasicProject
        {
            get { return (_context & VSContext.VisualBasicProject) != 0; }
        }

        public bool IsCSharpProject
        {
            get { return (_context & VSContext.CSharpProject) != 0; }
        }

        public bool IsCppProject
        {
            get { return (_context & VSContext.CppProject) != 0; }
        }

        public bool IsJSharpProject
        {
            get { return (_context & VSContext.JSharpProject) != 0; }
        }

        public bool IsWebProject
        {
            get { return (_context & VSContext.WebProject) != 0; }
        }

        public bool IsProjectContextMenu
        {
            get { return (_context & VSContext.ProjectContextMenu) != 0; }
        }

        public bool IsSolutionContextMenu
        {
            get { return (_context & VSContext.SolutionContextMenu) != 0; }
        }

        public bool IsItemContextMenu
        {
            get { return (_context & VSContext.ItemContextMenu) != 0; }
        }

        public bool IsMainBuildMenu
        {
            get { return (_context & VSContext.MainBuildMenu) != 0; }
        }

        public bool IsMainToolsMenu
        {
            get { return (_context & VSContext.MainToolsMenu) != 0; }
        }

        public bool IsProjectItem
        {
            get { return IsPhysicalFile || IsSolutionItem || (_context & VSContext.ProjectItem) != 0; }
        }

        public bool IsPhysicalFile
        {
            get { return (_context & VSContext.PhysicalFile) != 0; }
        }

        public bool IsPhysicalFolder
        {
            get { return (_context & VSContext.PhysicalFolder) != 0; }
        }

        public bool IsSolutionNode
        {
            get { return (_context & VSContext.SolutionNode) != 0; }
        }

        public bool IsVirtualFolder
        {
            get { return (_context & VSContext.VirtualFolder) != 0; }
        }

        public bool IsSubproject
        {
            get { return (_context & VSContext.Subproject) != 0; }
        }

        public bool IsCodeWindow
        {
            get { return (_context & VSContext.CodeWindow) != 0; }
        }

        public bool IsSolutionItem
        {
            get { return (_context & VSContext.SolutionItem) != 0; }
        }

        public bool IsNETStandardProject
        {
            get { return (_context & VSContext.NETStandardProject) != 0; }
        }

        public VisualStudioContext WithIsNone(bool isNone)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.None, isNone));
        }

        public VisualStudioContext WithIsContextMenus(bool isContextMenus)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.ContextMenus, isContextMenus));
        }

        public VisualStudioContext WithIsFolderContextMenu(bool isFolderContextMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.FolderContextMenu, isFolderContextMenu));
        }

        public VisualStudioContext WithIsProjectSolutionContextMenus(bool isProjectSolutionContextMenus)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.ProjectSolutionContextMenus, isProjectSolutionContextMenus));
        }

        public VisualStudioContext WithIsProject(bool isProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.Project, isProject));
        }

        public VisualStudioContext WithIsSolutionFolder(bool isSolutionFolder)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.SolutionFolder, isSolutionFolder));
        }

        public VisualStudioContext WithIsVisualBasicProject(bool isVisualBasicProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.VisualBasicProject, isVisualBasicProject));
        }

        public VisualStudioContext WithIsCSharpProject(bool isCSharpProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.CSharpProject, isCSharpProject));
        }

        public VisualStudioContext WithIsCppProject(bool isCppProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.CppProject, isCppProject));
        }

        public VisualStudioContext WithIsJSharpProject(bool isJSharpProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.JSharpProject, isJSharpProject));
        }

        public VisualStudioContext WithIsWebProject(bool isWebProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.WebProject, isWebProject));
        }

        public VisualStudioContext WithIsProjectContextMenu(bool isProjectContextMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.ProjectContextMenu, isProjectContextMenu));
        }

        public VisualStudioContext WithIsSolutionContextMenu(bool isSolutionContextMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.SolutionContextMenu, isSolutionContextMenu));
        }

        public VisualStudioContext WithIsItemContextMenu(bool isItemContextMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.ItemContextMenu, isItemContextMenu));
        }

        public VisualStudioContext WithIsMainBuildMenu(bool isMainBuildMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.MainBuildMenu, isMainBuildMenu));
        }

        public VisualStudioContext WithIsMainToolsMenu(bool isMainToolsMenu)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.MainToolsMenu, isMainToolsMenu));
        }

        public VisualStudioContext WithIsProjectItem(bool isProjectItem)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.ProjectItem, isProjectItem));
        }

        public VisualStudioContext WithIsPhysicalFile(bool isPhysicalFile)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.PhysicalFile, isPhysicalFile));
        }

        public VisualStudioContext WithIsPhysicalFolder(bool isPhysicalFolder)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.PhysicalFolder, isPhysicalFolder));
        }

        public VisualStudioContext WithIsSolutionNode(bool isSolutionNode)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.SolutionNode, isSolutionNode));
        }

        public VisualStudioContext WithIsVirtualFolder(bool isVirtualFolder)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.VirtualFolder, isVirtualFolder));
        }

        public VisualStudioContext WithIsSubproject(bool isSubproject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.Subproject, isSubproject));
        }

        public VisualStudioContext WithIsCodeWindow(bool isCodeWindow)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.CodeWindow, isCodeWindow));
        }

        public VisualStudioContext WithIsSolutionItem(bool isSolutionItem)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.CodeWindow, isSolutionItem));
        }

        public VisualStudioContext WithIsNETStandardProject(bool isNETStandardProject)
        {
            return new VisualStudioContext(SetFlag(_context, VSContext.NETStandardProject, isNETStandardProject));
        }

        public static VisualStudioContext None => new VisualStudioContext(VSContext.None);

        public static VisualStudioContext ContextMenus => new VisualStudioContext(VSContext.ContextMenus);

        public static VisualStudioContext FolderContextMenu => new VisualStudioContext(VSContext.FolderContextMenu);

        public static VisualStudioContext ProjectSolutionContextMenus => new VisualStudioContext(VSContext.ProjectSolutionContextMenus);

        public static VisualStudioContext Project => new VisualStudioContext(VSContext.Project);

        public static VisualStudioContext SolutionFolder => new VisualStudioContext(VSContext.SolutionFolder);

        public static VisualStudioContext VisualBasicProject => new VisualStudioContext(VSContext.VisualBasicProject);

        public static VisualStudioContext CSharpProject => new VisualStudioContext(VSContext.CSharpProject);

        public static VisualStudioContext CppProject => new VisualStudioContext(VSContext.CppProject);

        public static VisualStudioContext JSharpProject => new VisualStudioContext(VSContext.JSharpProject);

        public static VisualStudioContext WebProject => new VisualStudioContext(VSContext.WebProject);

        public static VisualStudioContext ProjectContextMenu => new VisualStudioContext(VSContext.ProjectContextMenu);

        public static VisualStudioContext SolutionContextMenu => new VisualStudioContext(VSContext.SolutionContextMenu);

        public static VisualStudioContext ItemContextMenu => new VisualStudioContext(VSContext.ItemContextMenu);

        public static VisualStudioContext MainBuildMenu => new VisualStudioContext(VSContext.MainBuildMenu);

        public static VisualStudioContext MainToolsMenu => new VisualStudioContext(VSContext.MainToolsMenu);

        public static VisualStudioContext ProjectItem => new VisualStudioContext(VSContext.ProjectItem);

        public static VisualStudioContext PhysicalFile => new VisualStudioContext(VSContext.PhysicalFile);

        public static VisualStudioContext PhysicalFolder => new VisualStudioContext(VSContext.PhysicalFolder);

        public static VisualStudioContext SolutionNode => new VisualStudioContext(VSContext.SolutionNode);

        public static VisualStudioContext VirtualFolder => new VisualStudioContext(VSContext.VirtualFolder);

        public static VisualStudioContext Subproject => new VisualStudioContext(VSContext.Subproject);

        public static VisualStudioContext CodeWindow => new VisualStudioContext(VSContext.CodeWindow);

        public static VisualStudioContext SolutionItem => new VisualStudioContext(VSContext.SolutionItem);
        public static VisualStudioContext NETStandardProject => new VisualStudioContext(VSContext.NETStandardProject);

        public static VisualStudioContext operator |(VisualStudioContext left, VisualStudioContext right)
        {
            return new VisualStudioContext(left._context | right._context);
        }

        public static VisualStudioContext operator &(VisualStudioContext left, VisualStudioContext right)
        {
            return new VisualStudioContext(left._context & right._context);
        }

        public static VisualStudioContext operator +(VisualStudioContext left, VisualStudioContext right)
        {
            return new VisualStudioContext(left._context | right._context);
        }

        public static VisualStudioContext operator -(VisualStudioContext left, VisualStudioContext right)
        {
            return new VisualStudioContext(left._context & ~right._context);
        }

        public bool Equals(VisualStudioContext other)
        {
            return _context == other._context;
        }

        public override bool Equals(object obj)
        {
            return obj is VisualStudioContext && Equals((VisualStudioContext) obj);
        }

        public override int GetHashCode()
        {
            return (int) _context;
        }

        public static bool operator ==(VisualStudioContext left, VisualStudioContext right)
        {
            return left._context == right._context;
        }

        public static bool operator !=(VisualStudioContext left, VisualStudioContext right)
        {
            return left._context != right._context;
        }

        public override string ToString()
        {
            return _context.ToString();
        }

        public static bool TryParse(string value, out VisualStudioContext other)
        {
            if (Enum.TryParse(value, out VSContext o))
            {
                other = new VisualStudioContext(o);
                return true;
            }
            else
            {
                other = default(VisualStudioContext);
                return false;
            }
        }
    }
}