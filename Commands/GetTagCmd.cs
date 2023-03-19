using System;
using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.Internal.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace InsertTag
{
    [Command(PackageIds.GetTagCmd)]
    internal sealed class GetTagCmd : BaseCommand<GetTagCmd>
    {
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            Properties.Settings.Default.Tag  =  Interaction.InputBox("Enter your tag:", "Input", "");
            Properties.Settings.Default.Save();
            return Task.CompletedTask;
        }
    }
}



