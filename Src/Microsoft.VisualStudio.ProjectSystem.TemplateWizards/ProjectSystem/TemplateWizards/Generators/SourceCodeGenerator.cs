// ----------------------------------------------------------------------------
//  <copyright file="SourceCodeGenerator.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators
{
    internal static class SourceCodeGenerator
    {
        public static SourceText GenerateCapabilitiesProviderSourceText(string targetNamespace, string className)
        {
            var sb = new System.Text.StringBuilder(3757);
            sb.AppendLine(@"// ----------------------------------------------------------------------------");
            sb.AppendLine($@"//  <copyright file=""{className}.cs"" company=""Ollon, LLC"">");
            sb.AppendLine(@"//      Copyright © 2017 Ollon, LLC. All Rights Reserved.");
            sb.AppendLine(@"//  </copyright>");
            sb.AppendLine(@"// ----------------------------------------------------------------------------");
            sb.AppendLine(@"");
            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Immutable;");
            sb.AppendLine(@"using System.ComponentModel.Composition;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"using Microsoft.VisualStudio.Threading;");
            sb.AppendLine(@"using Microsoft.VisualStudio.ProjectSystem;");
            sb.AppendLine(@"");
            sb.AppendLine($@"namespace {targetNamespace}");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    [Export(ExportContractNames.Scopes.UnconfiguredProject, typeof(IProjectCapabilitiesProvider))]");
            sb.AppendLine(@"    [AppliesTo(ProjectCapabilities.AlwaysApplicable)]");
            sb.AppendLine(@"    [SupportsFileExtension("".msbuildproj"")]");
            sb.AppendLine($@"    internal class {className} : UnconfiguredProjectCapabilitiesProviderBase");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        private readonly ImmutableHashSet<string> capabilities =");
            sb.AppendLine(@"                Empty.CapabilitiesSet");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.WindowsXaml)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.WindowsXamlPage)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.WindowsXamlCodeBehind)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.WindowsXamlResourceDictionary)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.WindowsXamlUserControl)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.DiagnoseCapabilities)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.HandlesOwnReload)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.NoGeneralDependentFileIcon)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.RelativePathDerivedDefaultNamespace)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.ComReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.ProjectReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.SharedProjectReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.SdkReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.PackageReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.OutputGroups)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.AllTargetOutputGroups)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.VisualStudioWellKnownOutputGroups)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.AssemblyReferences)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.LanguageService)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.CSharp)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.DynamicDependentFile)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.HostSetActiveProjectConfiguration)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.ProjectConfigurationsInferredFromUsage)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.ProjectConfigurationsDeclaredAsItems)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.SingleFileGenerators)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.RunningInVisualStudio)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.RenameNearbySimilarlyNamedImportsWithProject)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.ShowMissingItemTypes)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.Managed)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.ReferencesFolder)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.SharedAssetsProject)");
            sb.AppendLine(@"                    //.Add(ProjectCapabilities.NestedProjects)");
            sb.AppendLine(@"                    .Add(ProjectCapabilities.SourceItemsFromImports)");
            sb.AppendLine(@"                    .Add(""Pack"")");
            sb.AppendLine(@"                    .Add(""OpenProjectFile"")");
            sb.AppendLine(@"                    .Add(""PreserveFormatting"")");
            sb.AppendLine(@"            ;");
            sb.AppendLine(@"");
            sb.AppendLine(@"        [ImportingConstructor]");
            sb.AppendLine($@"        public {className}(UnconfiguredProject unconfiguredProject) : base(nameof({className}), unconfiguredProject)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        protected override async Task<ImmutableHashSet<string>> GetCapabilitiesAsync(CancellationToken cancellationToken)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            return await Task.FromResult(capabilities);");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");
            return SourceText.From(sb.ToString());

        }
        public static SourceText GenerateXamlPropertyRuleSourceText(string ruleName)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
            sb.AppendLine(@"<Rule");
            sb.AppendLine($@"    Name=""{ruleName}""");
            sb.AppendLine($@"    DisplayName=""{ruleName}""");
            sb.AppendLine(@"    PageTemplate=""tool""");
            sb.AppendLine($@"    Description=""{ruleName}""");
            sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
            sb.AppendLine(@"    <Rule.DataSource>");
            sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""True""/>");
            sb.AppendLine(@"    </Rule.DataSource>");
            sb.AppendLine(@"");
            sb.AppendLine(@"    <Rule.Categories>");
            sb.AppendLine(@"        <Category Name=""General"" DisplayName=""General""/>");
            sb.AppendLine(@"    </Rule.Categories>");
            sb.AppendLine(@"");
            sb.AppendLine(@"</Rule>");
            return SourceText.From(sb.ToString());
        }
        public static SourceText GenerateAsyncCommandGroupHandlerSourceText(string targetNamespace, string className)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Immutable;");
            sb.AppendLine(@"using System.ComponentModel.Composition;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"");
            sb.AppendLine($@"namespace {targetNamespace}");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    [ExportCommandGroup(VSConstants.CMDSETID.StandardCommandSet97_string)]");
            sb.AppendLine($@"    public class {className} : IAsyncCommandGroupHandler");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        private readonly IProjectThreadingService _threadingService;");
            sb.AppendLine(@"        private readonly UnconfiguredProject _unconfiguredProject;");
            sb.AppendLine(@"        private readonly IProjectLockService _projectLockService;");
            sb.AppendLine(@"        private readonly IProjectAsynchronousTasksService _taskService;");
            sb.AppendLine(@"        private readonly IProjectItemProvider _projectItemProvider;");
            sb.AppendLine(@"");
            sb.AppendLine(@"        [ImportingConstructor]");
            sb.AppendLine($@"        public {className}(IProjectThreadingService threadingService, UnconfiguredProject unconfiguredProject, IProjectLockService projectLockService, IProjectAsynchronousTasksService taskService, IProjectItemProvider projectItemProvider)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            _threadingService = threadingService;");
            sb.AppendLine(@"            _unconfiguredProject = unconfiguredProject;");
            sb.AppendLine(@"            _projectLockService = projectLockService;");
            sb.AppendLine(@"            _taskService = taskService;");
            sb.AppendLine(@"            _projectItemProvider = projectItemProvider;");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        public async Task<CommandStatusResult> GetCommandStatusAsync(IImmutableSet<IProjectTree> nodes, long commandId, bool focused, string commandText, CommandStatus progressiveStatus)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            await _taskService.DrainTaskQueueAsync();");
            sb.AppendLine(@"");
            sb.AppendLine(@"            CommandStatusResult result = CommandStatusResult.Unhandled;");
            sb.AppendLine(@"");
            sb.AppendLine(@"            switch ((VSConstants.VSStd97CmdID)commandId)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                case VSConstants.VSStd97CmdID.AddNewItem:");
            sb.AppendLine(@"                    progressiveStatus |= CommandStatus.Enabled | CommandStatus.Supported;");
            sb.AppendLine(@"                    result = new CommandStatusResult(true, commandText, progressiveStatus);");
            sb.AppendLine(@"                    break;");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return result;");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        public async Task<bool> TryHandleCommandAsync(IImmutableSet<IProjectTree> nodes, long commandId, bool focused, long commandExecuteOptions, IntPtr variantArgIn, IntPtr variantArgOut)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            await _taskService.DrainTaskQueueAsync();");
            sb.AppendLine(@"");
            sb.AppendLine(@"            bool result = false;");
            sb.AppendLine(@"");
            sb.AppendLine(@"            switch ((VSConstants.VSStd97CmdID)commandId)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                case VSConstants.VSStd97CmdID.AddNewItem:");
            sb.AppendLine(@"                    // Do Something");
            sb.AppendLine(@"                    result = true;");
            sb.AppendLine(@"                    break;");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return result;");
            sb.AppendLine(@"");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");
            return SourceText.From(sb.ToString());

        }
        public static SourceText GenerateGlobalPropeertiesProviderSourceText(string targetNamespace, string className)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(@"// ----------------------------------------------------------------------------");
            sb.AppendLine($@"//  <copyright file=""{className}.cs"" company=""Ollon, LLC"">");
            sb.AppendLine(@"//      Copyright © 2017 Ollon, LLC. All Rights Reserved.");
            sb.AppendLine(@"//  </copyright>");
            sb.AppendLine(@"// ----------------------------------------------------------------------------");
            sb.AppendLine(@"");
            sb.AppendLine(@"using System.Collections.Immutable;");
            sb.AppendLine(@"using System.ComponentModel.Composition;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"using Microsoft.VisualStudio.ProjectSystem;");
            sb.AppendLine(@"using Microsoft.VisualStudio.ProjectSystem.Build;");
            sb.AppendLine(@"");
            sb.AppendLine($@"namespace {targetNamespace}");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    [ExportBuildGlobalPropertiesProvider]");
            sb.AppendLine(@"    [AppliesTo(ProjectCapabilities.AlwaysApplicable)]");
            sb.AppendLine($@"    internal class {className} : StaticGlobalPropertiesProviderBase");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        private IProjectService _projectService;");
            sb.AppendLine(@"");
            sb.AppendLine(@"        private static readonly Task<IImmutableDictionary<string, string>> BuildProperties =");
            sb.AppendLine(@"            Task.FromResult((IImmutableDictionary<string, string>) Empty.PropertiesMap);");
            sb.AppendLine(@"");
            sb.AppendLine(@"        [ImportingConstructor]");
            sb.AppendLine($@"        public {className}(IProjectService projectService)");
            sb.AppendLine(@"            :base(projectService.Services)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            _projectService = projectService;");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        public override Task<IImmutableDictionary<string, string>> GetGlobalPropertiesAsync(CancellationToken cancellationToken)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            return BuildProperties;");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");
            return SourceText.From(sb.ToString());
        }
        public static CompilationUnitSyntax GenerateGlobalPropertiesProviderCompilationUnit(Workspace workspace, string targetNamespace, string className)
        {
            CompilationUnitSyntax unit = SyntaxFactory.CompilationUnit();
            SyntaxList<UsingDirectiveSyntax> usings = SyntaxFactory.List(
                new[]
                {
                    Using("System.Collections.Immutable"),
                    Using("System.ComponentModel.Composition"),
                    Using("System.Threading"),
                    Using("System.Threading.Tasks"),
                    Using("Microsoft.VisualStudio.ProjectSystem"),
                    Using("Microsoft.VisualStudio.ProjectSystem.Build")
                }
            );
            unit = unit.WithUsings(usings);
            unit = unit.WithLeadingTrivia(GenerateLicenseHeader($"{className}.cs"));
            NamespaceDeclarationSyntax ns = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(targetNamespace));
            ClassDeclarationSyntax cd = GenerateGlobalPropertiesProviderClass(className);
            cd = cd.WithAttributeLists(GenerateExportBuildGlobalPropertiesProviderAttribute());
            ns = ns.AddMembers(cd);
            unit = unit.AddMembers(ns);
            unit = (CompilationUnitSyntax) Formatter.Format(unit, workspace);
            return unit;
        }


        private static SyntaxTriviaList GenerateLicenseHeader(string fileName)
        {
            return SyntaxFactory.TriviaList(
                SyntaxFactory.Comment("// ----------------------------------------------------------------------------"),
                SyntaxFactory.CarriageReturnLineFeed,
                SyntaxFactory.Comment($"//  <copyright file=\"{fileName}\" company=\"Ollon, LLC\">"),
                SyntaxFactory.CarriageReturnLineFeed,
                SyntaxFactory.Comment("//      Copyright © 2017 Ollon, LLC. All Rights Reserved."),
                SyntaxFactory.CarriageReturnLineFeed,
                SyntaxFactory.Comment("//  </copyright>"),
                SyntaxFactory.CarriageReturnLineFeed,
                SyntaxFactory.Comment("// ----------------------------------------------------------------------------"),
                SyntaxFactory.CarriageReturnLineFeed,
                SyntaxFactory.CarriageReturnLineFeed);
        }

        private static UsingDirectiveSyntax Using(string identifierName)
        {
            return SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName(identifierName));
        }

        private static ClassDeclarationSyntax GenerateGlobalPropertiesProviderClass(string className)
        {
            return SyntaxFactory.ClassDeclaration(className)
                .WithModifiers(
                    SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.InternalKeyword)))
                .WithBaseList(
                    SyntaxFactory.BaseList(
                        SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                            SyntaxFactory.SimpleBaseType(
                                SyntaxFactory.IdentifierName("StaticGlobalPropertiesProviderBase")))))
                .WithMembers(
                    SyntaxFactory.List(
                        new MemberDeclarationSyntax[]
                        {
                            SyntaxFactory.FieldDeclaration(
                                    SyntaxFactory.VariableDeclaration(
                                            SyntaxFactory.IdentifierName("IProjectService"))
                                        .WithVariables(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.VariableDeclarator(
                                                    SyntaxFactory.Identifier("_projectService")))))
                                .WithModifiers(
                                    SyntaxFactory.TokenList(
                                        SyntaxFactory.Token(SyntaxKind.PrivateKeyword))),
                            SyntaxFactory.FieldDeclaration(
                                    SyntaxFactory.VariableDeclaration(
                                            SyntaxFactory.GenericName(
                                                    SyntaxFactory.Identifier("Task"))
                                                .WithTypeArgumentList(
                                                    SyntaxFactory.TypeArgumentList(
                                                        SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                                                            SyntaxFactory.GenericName(
                                                                    SyntaxFactory.Identifier("IImmutableDictionary"))
                                                                .WithTypeArgumentList(
                                                                    SyntaxFactory.TypeArgumentList(
                                                                        SyntaxFactory.SeparatedList<TypeSyntax>(
                                                                            new SyntaxNodeOrToken[]
                                                                            {
                                                                                SyntaxFactory.PredefinedType(
                                                                                    SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                                                                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                                                                SyntaxFactory.PredefinedType(
                                                                                    SyntaxFactory.Token(SyntaxKind.StringKeyword))
                                                                            })))))))
                                        .WithVariables(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.VariableDeclarator(
                                                        SyntaxFactory.Identifier("BuildProperties"))
                                                    .WithInitializer(
                                                        SyntaxFactory.EqualsValueClause(
                                                            SyntaxFactory.InvocationExpression(
                                                                    SyntaxFactory.MemberAccessExpression(
                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                        SyntaxFactory.IdentifierName("Task"),
                                                                        SyntaxFactory.IdentifierName("FromResult")))
                                                                .WithArgumentList(
                                                                    SyntaxFactory.ArgumentList(
                                                                        SyntaxFactory.SingletonSeparatedList(
                                                                            SyntaxFactory.Argument(
                                                                                SyntaxFactory.CastExpression(
                                                                                    SyntaxFactory.GenericName(
                                                                                            SyntaxFactory.Identifier("IImmutableDictionary"))
                                                                                        .WithTypeArgumentList(
                                                                                            SyntaxFactory.TypeArgumentList(
                                                                                                SyntaxFactory.SeparatedList<TypeSyntax>(
                                                                                                    new SyntaxNodeOrToken[]
                                                                                                    {
                                                                                                        SyntaxFactory.PredefinedType(
                                                                                                            SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                                                                                                        SyntaxFactory.Token(SyntaxKind.CommaToken),
                                                                                                        SyntaxFactory.PredefinedType(
                                                                                                            SyntaxFactory.Token(SyntaxKind.StringKeyword))
                                                                                                    })))
                                                                                                    ,
                                                                                    SyntaxFactory.MemberAccessExpression(
                                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                                        SyntaxFactory.IdentifierName("Empty"),
                                                                                        SyntaxFactory.IdentifierName("PropertiesMap"))))))))))))
                                .WithModifiers(
                                    SyntaxFactory.TokenList(
                                        new[]
                                        {
                                            SyntaxFactory.Token(SyntaxKind.PrivateKeyword),
                                            SyntaxFactory.Token(SyntaxKind.StaticKeyword),
                                            SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)
                                        })),
                            SyntaxFactory.ConstructorDeclaration(
                                    SyntaxFactory.Identifier(className))
                                .WithAttributeLists(
                                    SyntaxFactory.SingletonList(
                                        SyntaxFactory.AttributeList(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.Attribute(
                                                    SyntaxFactory.IdentifierName("ImportingConstructor")))))).WithLeadingTrivia(
                                SyntaxFactory.CarriageReturnLineFeed,
                                SyntaxFactory.CarriageReturnLineFeed
                                ).WithAdditionalAnnotations(Formatter.Annotation)
                                .WithModifiers(
                                    SyntaxFactory.TokenList(
                                        SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                                .WithParameterList(
                                    SyntaxFactory.ParameterList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Parameter(
                                                    SyntaxFactory.Identifier("projectService"))
                                                .WithType(
                                                    SyntaxFactory.IdentifierName("IProjectService")))))
                                .WithInitializer(
                                    SyntaxFactory.ConstructorInitializer(
                                        SyntaxKind.BaseConstructorInitializer,
                                        SyntaxFactory.ArgumentList(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.Argument(
                                                    SyntaxFactory.MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        SyntaxFactory.IdentifierName("projectService"),
                                                        SyntaxFactory.IdentifierName("Services")))))))
                                .WithBody(
                                    SyntaxFactory.Block(
                                        SyntaxFactory.SingletonList<StatementSyntax>(
                                            SyntaxFactory.ExpressionStatement(
                                                SyntaxFactory.AssignmentExpression(
                                                    SyntaxKind.SimpleAssignmentExpression,
                                                    SyntaxFactory.IdentifierName("_projectService"),
                                                    SyntaxFactory.IdentifierName("projectService")))))),
                            SyntaxFactory.MethodDeclaration(
                                    SyntaxFactory.GenericName(
                                            SyntaxFactory.Identifier("Task"))
                                        .WithTypeArgumentList(
                                            SyntaxFactory.TypeArgumentList(
                                                SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                                                    SyntaxFactory.GenericName(
                                                            SyntaxFactory.Identifier("IImmutableDictionary"))
                                                        .WithTypeArgumentList(
                                                            SyntaxFactory.TypeArgumentList(
                                                                SyntaxFactory.SeparatedList<TypeSyntax>(
                                                                    new SyntaxNodeOrToken[]
                                                                    {
                                                                        SyntaxFactory.PredefinedType(
                                                                            SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                                                                        SyntaxFactory.Token(SyntaxKind.CommaToken),
                                                                        SyntaxFactory.PredefinedType(
                                                                            SyntaxFactory.Token(SyntaxKind.StringKeyword))
                                                                    })))))),
                                    SyntaxFactory.Identifier("GetGlobalPropertiesAsync"))
                                .WithModifiers(
                                    SyntaxFactory.TokenList(
                                        new[]
                                        {
                                            SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                                            SyntaxFactory.Token(SyntaxKind.OverrideKeyword)
                                        }))
                                .WithParameterList(
                                    SyntaxFactory.ParameterList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Parameter(
                                                    SyntaxFactory.Identifier("cancellationToken"))
                                                .WithType(
                                                    SyntaxFactory.IdentifierName("CancellationToken")))))
                                .WithBody(
                                    SyntaxFactory.Block(
                                        SyntaxFactory.SingletonList<StatementSyntax>(
                                            SyntaxFactory.ReturnStatement(
                                                SyntaxFactory.IdentifierName("BuildProperties")))))
                        }))
                .NormalizeWhitespace();

        }

        private static SyntaxList<AttributeListSyntax> GenerateExportBuildGlobalPropertiesProviderAttribute()
        {
            return SyntaxFactory.List(
                new[]
                {
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.Attribute(
                                SyntaxFactory.IdentifierName("ExportBuildGlobalPropertiesProvider")))),
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.Attribute(
                                    SyntaxFactory.IdentifierName("AppliesTo"))
                                .WithArgumentList(
                                    SyntaxFactory.AttributeArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.AttributeArgument(
                                                SyntaxFactory.MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    SyntaxFactory.IdentifierName("ProjectCapabilities"),
                                                    SyntaxFactory.IdentifierName("AlwaysApplicable"))))))))
                });
        }
    }
}