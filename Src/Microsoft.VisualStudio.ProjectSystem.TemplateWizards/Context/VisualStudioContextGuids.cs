namespace Microsoft.VisualStudio.Context
{
    /// <summary>
    ///     The contexts below are context only in relation to this project. Visual Studio Defines Contexts in other ways.
    ///     I use contexts to describe locations/surroudings while stomping around in code.
    ///     NOTE: This is a non-exhaustive list.
    /// </summary>
    /// <remarks></remarks>
    public static class VisualStudioContextGuids
    {
        /// <summary>   Context one enters when right-clicking a physical file in the IDE. </summary>
        public const string PhysicalFile = "{6BB5F8EE-4483-11D3-8BCF-00C04F8EC28C}";

        /// <summary>
        ///     Context one enters when right-clicking a physical folder in the IDE.
        ///     A good example of a physical folder is the folder one creates for projects. Solution
        ///     folders, on the other hand, are not physical and hence do to map to physicality; rather,
        ///     they are organizational units for grouping concepts.
        /// </summary>
        public const string PhysicalFolder = "{6BB5F8EF-4483-11D3-8BCF-00C04F8EC28C}";


        /// <summary>   Context one enters when right-clicking a folder that is neither physical, nor a solution folder. Dont really know what that would be,
        ///             except perhaps something like the References folder in a CSharp project or something.</summary>
        public const string VirtualFolder = "{6BB5F8F0-4483-11D3-8BCF-00C04F8EC28C}";


        /// <summary>   Context one enters when right-clicking a project's subproject. Whatever that is... </summary>
        public const string SubProject = "{EA6618E8-6E24-4528-94BE-6889FE16485C}";


        /// <summary>   Pathname of the solution folder. </summary>
        public const string SolutionFolder = "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}";

        /// <summary>   Context one enters when right-clicking the project node for a VB Project in the IDE. </summary>
        public const string VisualBasicProject = "{F184B08F-C81C-45F6-A57F-5ABD9991F28F}";

        /// <summary>   Context one enters when right-clicking the project node for a CSharp Project in the IDE. </summary>
        public const string CSharpProject = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";

        /// <summary>   Context one enters when right-clicking the project node for a C++ Project in the IDE. </summary>
        public const string CppProject = "{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}";

        /// <summary>   Context one enters when right-clicking the project node for a Web Project in the IDE. </summary>
        public const string WebProject = "{E24C65DC-7377-472b-9ABA-BC803B73C61A}";

        /// <summary>   Context when selecting an item in the solution items project or in a solution folder.</summary>
        public const string SolutionItem = "{66A26722-8FB5-11D2-AA7E-00C04F688DDE}";

        /// <summary>   Context when selecting project node in a .NETStandard Class Library.</summary>
        public const string NETStandardProject = "{9A19103-16F7-4668-BE54-9A1E7A4F7556}";
    }
}