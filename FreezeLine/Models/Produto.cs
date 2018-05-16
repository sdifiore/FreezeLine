using System.ComponentModel.DataAnnotations;

namespace FreezeLine.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Código")]
        public string Apelido { get; set; }

        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Peso Líquido")]
        [DisplayFormat(DataFormatString = "{0:N4}")]
        public float PesoLiquido { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Display(Name = "IPI")]
        [DisplayFormat(DataFormatString = "{0:P0}")]
        public float Ipi { get; set; }

        [Display(Name = "Qt/un")]
        public float QtdUnid { get; set; }

        [StringLength(16)]
        [Display(Name = "Ref Auxiliar Produto")]
        public string RefAuxiliarProduto { get; set; }

        [Display(Name = "Qt Un por Un Armz")]
        public int QtUnPorUnArmz { get; set; }

        [Display(Name = "Peso Líquido Calculado")]
        [DisplayFormat(DataFormatString = "{0:N4}")]
        public float PesoLiquidoCalc { get; set; }

        [Display(Name = "Item Estrutura")]
        public int ItemStru { get; set; }

        [Display(Name = "Custo Direto Total")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CustODirTotal { get; set; }

        [Display(Name = "Custo Mat última etapa")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CstMatUltmEtapa { get; set; }

        [Display(Name = "Custo Mat etapa 1")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CstMatEtapa1 { get; set; }

        [Display(Name = "Custo Mat etapa 2")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CstMatEtapa2 { get; set; }

        [Display(Name = "Custo Mat etapa 3")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CstMatEtapa3 { get; set; }

        [Display(Name = "Custo Tot Materiais")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CstTotMaterial { get; set; }

        [Display(Name = "Custo Direto MOD")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CustoDirMod { get; set; }

        [Display(Name = "Horas MOD última etapa")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public float HorasModUltmEtapa { get; set; }

        [Display(Name = "Horas MOD etapa 1")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public float HorasModEtapa1 { get; set; }

        [Display(Name = "Horas MOD etapa 2")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public float HorasModEtapa2 { get; set; }
    }
}