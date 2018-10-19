using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class ProcessoMap : ClassMapping<Processo> {
        
        public ProcessoMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdProcesso, map => { map.Column("id_processo"); map.NotNullable(true); });
			Property(x => x.Numero, map => map.NotNullable(true));
			Property(x => x.Ano, map => map.NotNullable(true));
			Property(x => x.IdTipoProcesso, map => { map.Column("id_tipo_processo"); map.NotNullable(true); });
			Property(x => x.IdTipoDocumento, map => { map.Column("id_tipo_documento"); map.NotNullable(true); });
			Property(x => x.IdMunicipio, map => map.Column("id_municipio"));
			Property(x => x.Data);
			Property(x => x.DataInstauracao, map => map.Column("data_instauracao"));
			Property(x => x.DataEncerramento, map => map.Column("data_encerramento"));
			Property(x => x.Placa);
			Property(x => x.Renavam);
			Property(x => x.PresidenteComissao, map => map.Column("presidente_comissao"));
			Property(x => x.SecretarioComissao, map => map.Column("secretario_comissao"));
			Property(x => x.MembroComissao, map => map.Column("membro_comissao"));
			Property(x => x.LocalFato, map => map.Column("local_fato"));
			Property(x => x.DataFato, map => map.Column("data_fato"));
			Property(x => x.PortariaInstautaracao, map => map.Column("portaria_instautaracao"));
			Property(x => x.Historico);
			Property(x => x.PortariaEncerramento, map => map.Column("portaria_encerramento"));
			Property(x => x.Punicao);
			Property(x => x.Andamento);
			Property(x => x.IdComissao, map => map.Column("id_comissao"));
			Property(x => x.ResumoPunicao, map => map.Column("resumo_punicao"));
			Property(x => x.Status);

            //Bag(x => x.Acusado, colmap =>  { colmap.Key(x => x.Column("id_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.Andamento, colmap =>  { colmap.Key(x => x.Column("id_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.Origem, colmap =>  { colmap.Key(x => x.Column("id_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.Testemunha, colmap =>  { colmap.Key(x => x.Column("id_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.Tramitar, colmap =>  { colmap.Key(x => x.Column("id_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
