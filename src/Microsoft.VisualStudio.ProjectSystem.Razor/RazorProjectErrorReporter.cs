using System;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.LanguageServices.Implementation.TaskList;

namespace Microsoft.VisualStudio.ProjectSystem.Razor
{
    internal class RazorProjectErrorReporter : ProjectExternalErrorReporter
    {
        public RazorProjectErrorReporter(ProjectId projectId, string errorCodePrefix, IServiceProvider serviceProvider) 
            : base(projectId, errorCodePrefix, serviceProvider)
        {
        }
    }
}
