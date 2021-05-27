using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synapse.Api.Plugin;
using Synapse;


namespace Target_Warning
{
    [PluginInformation(
        Author = "Wuffeli",
        Description = "SCP 096-1 Target Alert",
        LoadPriority = 0,
        Name = "Target Alert",
        SynapseMajor = 2,
        SynapseMinor = 6,
        SynapsePatch = 1,
        Version = "1"
        )]
    public class Pluginclass : AbstractPlugin
    {
        public override void Load()
        {
            base.Load();
            Synapse.Api.Logger.Get.Info("Target Alert started successfully");
            Server.Get.Events.Scp.Scp096.Scp096AddTargetEvent += Scp096_Scp096AddTargetEvent;
        }

        private void Scp096_Scp096AddTargetEvent(Synapse.Api.Events.SynapseEventArguments.Scp096AddTargetEventArgument ev)
        {
            ev.Player.GiveTextHint("You are getting targeted by SCP-096", 1);
        }

 
    }
}
