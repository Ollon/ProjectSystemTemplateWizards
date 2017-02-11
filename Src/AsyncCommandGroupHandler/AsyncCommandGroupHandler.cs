using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.ProjectSystem;

namespace Namespace
{
    [ExportCommandGroup(VSConstants.CMDSETID.StandardCommandSet97_string)]
    public class ClassName : IAsyncCommandGroupHandler
    {
        private readonly IProjectThreadingService _threadingService;
        private readonly UnconfiguredProject _unconfiguredProject;
        private readonly IProjectLockService _projectLockService;
        private readonly IProjectAsynchronousTasksService _taskService;
        private readonly IProjectItemProvider _projectItemProvider;

        [ImportingConstructor]
        public ClassName(IProjectThreadingService threadingService, UnconfiguredProject unconfiguredProject, IProjectLockService projectLockService, IProjectAsynchronousTasksService taskService, IProjectItemProvider projectItemProvider)
        {
            _threadingService = threadingService;
            _unconfiguredProject = unconfiguredProject;
            _projectLockService = projectLockService;
            _taskService = taskService;
            _projectItemProvider = projectItemProvider;
        }

        public async Task<CommandStatusResult> GetCommandStatusAsync(IImmutableSet<IProjectTree> nodes, long commandId, bool focused, string commandText, CommandStatus progressiveStatus)
        {
            await _taskService.DrainTaskQueueAsync();

            CommandStatusResult result = CommandStatusResult.Unhandled;

            switch ((VSConstants.VSStd97CmdID)commandId)
            {            
                case VSConstants.VSStd97CmdID.AddNewItem:
                    progressiveStatus |= CommandStatus.Enabled | CommandStatus.Supported;
                    result = new CommandStatusResult(true, commandText, progressiveStatus);
                    break;
            }

            return result;
        }

        public async Task<bool> TryHandleCommandAsync(IImmutableSet<IProjectTree> nodes, long commandId, bool focused, long commandExecuteOptions, IntPtr variantArgIn, IntPtr variantArgOut)
        {
            await _taskService.DrainTaskQueueAsync();

            bool result = false;

            switch ((VSConstants.VSStd97CmdID)commandId)
            {
                case VSConstants.VSStd97CmdID.AddNewItem:
                    // Do Something
                    result = true;
                    break;
            }

            return result;

        }
    }
}
