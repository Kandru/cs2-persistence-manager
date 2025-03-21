using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Utils;
using System.Globalization;
using System.Text.Json.Serialization;

namespace PersistenceManager
{
    public partial class PersistenceManager : BasePlugin, IPluginConfig<PluginConfig>
    {
        public override string ModuleName => "CS2 PersistenceManager";
        public override string ModuleAuthor => "Originally by Franc1sco Franug / rewritten by Jon-Mailes Graeffe <mail@jonni.it> and Kalle <kalle@kandru.de>";

        public override void Load(bool hotReload)
        {

        }

        public override void Unload(bool hotReload)
        {

        }
    }
}
