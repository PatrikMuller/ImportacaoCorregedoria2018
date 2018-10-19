using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Sysdiagrams {
        public virtual int DiagramId { get; set; }
        public virtual string Name { get; set; }
        public virtual int PrincipalId { get; set; }
        public virtual int? Version { get; set; }
        public virtual byte[] Definition { get; set; }
    }
}
