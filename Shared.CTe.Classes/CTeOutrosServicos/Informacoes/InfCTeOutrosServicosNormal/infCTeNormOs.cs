﻿using System.Collections.Generic;
using System.Xml.Serialization;
using CTe.Classes.Informacoes;
using CTe.Classes.Informacoes.infCteAnu;
using CTe.Classes.Informacoes.infCteComp;
using CTe.Classes.Informacoes.infCTeNormal;

namespace DFe.DocumentosEletronicos.CTe.CTeOS.Informacoes.InfCTeNormal
{
    public class infCTeNormOs
    {
        public infServico infServico { get; set; }

        [XmlElement("infDocRef")]
        public List<infDocRef> infDocRef { get; set; }

        [XmlElement("seg")]
        public List<segOs> seg { get; set; }

        [XmlElement("infModal")]
        public infModalOs infModal { get; set; }

        [XmlElement("infCteSub")]
        public infCteSubOs infCteSub { get; set; }

        public infCteComp infCteComp { get; set; }

        public infCteAnu infCteAnu { get; set; }

        public List<autXML> autXml { get; set; }
    }
}