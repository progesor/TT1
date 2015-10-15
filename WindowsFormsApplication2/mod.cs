using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    public class mod
    {

        private string name;

        /// <summary>
        /// The name of the mod.
        /// </summary>
        /// <value>"Forge"</value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string other;

        /// <summary>
        /// Does not exist when empty. Aliases and nametags for the mod.
        /// </summary>
        /// <value>"(API)"</value>
        public string Other
        {
            get { return other; }
            set { other = value; }
        }

        private string link;

        /// <summary>
        /// The link to the mod page. All links are bitly links so that anyone can view its statistics.
        /// </summary>
        /// <value>"http://bit.ly/forge-dl"</value>
        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        private string desc;

        /// <summary>
        /// The description of the mod. May contain HTML tags. We are considering the possibility of using Markdown instead.
        /// </summary>
        /// <value>"..."</value>
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        private string[] author;

        /// <summary>
        /// The name(s) of the mod author(s).
        /// </summary>
        /// <value>["LexManos"]</value>
        public string[] Author
        {
            get { return author; }
            set { author = value; }
        }

        private string source;

        /// <summary>
        /// Does not exist when not open source. The link to the page of the mod's source code.
        /// </summary>
        /// <value>"https://github.com/MinecraftForge/MinecraftForge"</value>
        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        private string[] type;

        /// <summary>
        /// The type of the mod. May contain up to 3 values.
        /// Possible values: Universal, Client, Server, SSP, SMP and LAN
        /// </summary>
        /// <value>["Universal"]</value>
        public string[] Type
        {
            get { return type; }
            set { type = value; }
        }

        private string[] dependencies;

        /// <summary>
        /// The Forge compatibility of a mod, followed by any additional dependencies.
        /// Forge Required - The mod requires Forge.
        /// Forge Compatible - The mod is compatible with Forge but does not require it.
        /// Not Forge Compatible - The mod cannot run with Forge.
        /// Base Edit - The mod contains base edits. Note that Forge Required mods can still be Base Edit mods.
        /// </summary>
        /// <value>["Forge Required","FML"]</value>
        public string[] Dependencies
        {
            get { return dependencies; }
            set { dependencies = value; }
        }

        private string[] version;

        /// <summary>
        /// The versions supported by this mod entry.
        /// </summary>
        /// <value>["1.7.2","1.6.4","1.5.2"]</value>
        public string[] Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
