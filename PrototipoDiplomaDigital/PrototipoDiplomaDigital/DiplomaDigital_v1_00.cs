﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
[System.Xml.Serialization.XmlRootAttribute("Diploma", Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd", IsNullable=false)]
public partial class TDiploma {
    
    private TInfDiploma infDiplomaField;
    
    private SignatureType signatureField;
    
    /// <remarks/>
    public TInfDiploma infDiploma {
        get {
            return this.infDiplomaField;
        }
        set {
            this.infDiplomaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType Signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TInfDiploma {
    
    private TDadosDiploma dadosDiplomaField;
    
    private TDadosRegistro dadosRegistroField;
    
    private TVersao versaoField;
    
    private string idField;
    
    /// <remarks/>
    public TDadosDiploma DadosDiploma {
        get {
            return this.dadosDiplomaField;
        }
        set {
            this.dadosDiplomaField = value;
        }
    }
    
    /// <remarks/>
    public TDadosRegistro DadosRegistro {
        get {
            return this.dadosRegistroField;
        }
        set {
            this.dadosRegistroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TVersao versao {
        get {
            return this.versaoField;
        }
        set {
            this.versaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosDiploma {
    
    private TDadosDiplomado diplomadoField;
    
    private TDadosCurso dadosCursoField;
    
    private TDadosIesEmissora iesEmissoraField;
    
    private SignatureType[] signatureField;
    
    private string idField;
    
    /// <remarks/>
    public TDadosDiplomado Diplomado {
        get {
            return this.diplomadoField;
        }
        set {
            this.diplomadoField = value;
        }
    }
    
    /// <remarks/>
    public TDadosCurso DadosCurso {
        get {
            return this.dadosCursoField;
        }
        set {
            this.dadosCursoField = value;
        }
    }
    
    /// <remarks/>
    public TDadosIesEmissora IesEmissora {
        get {
            return this.iesEmissoraField;
        }
        set {
            this.iesEmissoraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType[] Signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosDiplomado {
    
    private string idField;
    
    private string nomeField;
    
    private string nomeSocialField;
    
    private TSexo sexoField;
    
    private string nacionalidadeField;
    
    private TNaturalidade naturalidadeField;
    
    private string cPFField;
    
    private TRg rgField;
    
    private System.DateTime dataNascimentoField;
    
    /// <remarks/>
    public string ID {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Nome {
        get {
            return this.nomeField;
        }
        set {
            this.nomeField = value;
        }
    }
    
    /// <remarks/>
    public string NomeSocial {
        get {
            return this.nomeSocialField;
        }
        set {
            this.nomeSocialField = value;
        }
    }
    
    /// <remarks/>
    public TSexo Sexo {
        get {
            return this.sexoField;
        }
        set {
            this.sexoField = value;
        }
    }
    
    /// <remarks/>
    public string Nacionalidade {
        get {
            return this.nacionalidadeField;
        }
        set {
            this.nacionalidadeField = value;
        }
    }
    
    /// <remarks/>
    public TNaturalidade Naturalidade {
        get {
            return this.naturalidadeField;
        }
        set {
            this.naturalidadeField = value;
        }
    }
    
    /// <remarks/>
    public string CPF {
        get {
            return this.cPFField;
        }
        set {
            this.cPFField = value;
        }
    }
    
    /// <remarks/>
    public TRg RG {
        get {
            return this.rgField;
        }
        set {
            this.rgField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DataNascimento {
        get {
            return this.dataNascimentoField;
        }
        set {
            this.dataNascimentoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TSexo {
    
    /// <remarks/>
    F,
    
    /// <remarks/>
    M,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TNaturalidade {
    
    private string codigoMunicipioField;
    
    private string nomeMunicipioField;
    
    private TUf ufField;
    
    /// <remarks/>
    public string CodigoMunicipio {
        get {
            return this.codigoMunicipioField;
        }
        set {
            this.codigoMunicipioField = value;
        }
    }
    
    /// <remarks/>
    public string NomeMunicipio {
        get {
            return this.nomeMunicipioField;
        }
        set {
            this.nomeMunicipioField = value;
        }
    }
    
    /// <remarks/>
    public TUf UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TUf {
    
    /// <remarks/>
    AC,
    
    /// <remarks/>
    AL,
    
    /// <remarks/>
    AM,
    
    /// <remarks/>
    AP,
    
    /// <remarks/>
    BA,
    
    /// <remarks/>
    CE,
    
    /// <remarks/>
    DF,
    
    /// <remarks/>
    ES,
    
    /// <remarks/>
    GO,
    
    /// <remarks/>
    MA,
    
    /// <remarks/>
    MG,
    
    /// <remarks/>
    MS,
    
    /// <remarks/>
    MT,
    
    /// <remarks/>
    PA,
    
    /// <remarks/>
    PB,
    
    /// <remarks/>
    PE,
    
    /// <remarks/>
    PI,
    
    /// <remarks/>
    PR,
    
    /// <remarks/>
    RJ,
    
    /// <remarks/>
    RN,
    
    /// <remarks/>
    RO,
    
    /// <remarks/>
    RR,
    
    /// <remarks/>
    RS,
    
    /// <remarks/>
    SC,
    
    /// <remarks/>
    SE,
    
    /// <remarks/>
    SP,
    
    /// <remarks/>
    TO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TRg {
    
    private string numeroField;
    
    private TUf ufField;
    
    /// <remarks/>
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
    
    /// <remarks/>
    public TUf UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosCurso {
    
    private string nomeCursoField;
    
    private uint codigoCursoEMECField;
    
    private string nomeHabilitacaoField;
    
    private TModalidadeCurso modalidadeField;
    
    private TTituloConferido tituloConferidoField;
    
    private TGrauConferido grauConferidoField;
    
    private TEndereco enderecoCursoField;
    
    private TPolo poloField;
    
    private TAtoRegulatorio autorizacaoField;
    
    private TAtoRegulatorio reconhecimentoField;
    
    private TAtoRegulatorio renovacaoReconhecimentoField;
    
    /// <remarks/>
    public string NomeCurso {
        get {
            return this.nomeCursoField;
        }
        set {
            this.nomeCursoField = value;
        }
    }
    
    /// <remarks/>
    public uint CodigoCursoEMEC {
        get {
            return this.codigoCursoEMECField;
        }
        set {
            this.codigoCursoEMECField = value;
        }
    }
    
    /// <remarks/>
    public string NomeHabilitacao {
        get {
            return this.nomeHabilitacaoField;
        }
        set {
            this.nomeHabilitacaoField = value;
        }
    }
    
    /// <remarks/>
    public TModalidadeCurso Modalidade {
        get {
            return this.modalidadeField;
        }
        set {
            this.modalidadeField = value;
        }
    }
    
    /// <remarks/>
    public TTituloConferido TituloConferido {
        get {
            return this.tituloConferidoField;
        }
        set {
            this.tituloConferidoField = value;
        }
    }
    
    /// <remarks/>
    public TGrauConferido GrauConferido {
        get {
            return this.grauConferidoField;
        }
        set {
            this.grauConferidoField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco EnderecoCurso {
        get {
            return this.enderecoCursoField;
        }
        set {
            this.enderecoCursoField = value;
        }
    }
    
    /// <remarks/>
    public TPolo Polo {
        get {
            return this.poloField;
        }
        set {
            this.poloField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Autorizacao {
        get {
            return this.autorizacaoField;
        }
        set {
            this.autorizacaoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Reconhecimento {
        get {
            return this.reconhecimentoField;
        }
        set {
            this.reconhecimentoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio RenovacaoReconhecimento {
        get {
            return this.renovacaoReconhecimentoField;
        }
        set {
            this.renovacaoReconhecimentoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TModalidadeCurso {
    
    /// <remarks/>
    Presencial,
    
    /// <remarks/>
    EAD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TTituloConferido {
    
    /// <remarks/>
    Bacharel,
    
    /// <remarks/>
    Engenheiro,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TGrauConferido {
    
    /// <remarks/>
    Tecnólogo,
    
    /// <remarks/>
    Bacharelado,
    
    /// <remarks/>
    Licenciatura,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Curso sequencial")]
    Cursosequencial,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TEndereco {
    
    private string logradouroField;
    
    private string numeroField;
    
    private string complementoField;
    
    private string bairroField;
    
    private string codigoMunicipioField;
    
    private string nomeMunicipioField;
    
    private TUf ufField;
    
    private string cEPField;
    
    /// <remarks/>
    public string Logradouro {
        get {
            return this.logradouroField;
        }
        set {
            this.logradouroField = value;
        }
    }
    
    /// <remarks/>
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
    
    /// <remarks/>
    public string Complemento {
        get {
            return this.complementoField;
        }
        set {
            this.complementoField = value;
        }
    }
    
    /// <remarks/>
    public string Bairro {
        get {
            return this.bairroField;
        }
        set {
            this.bairroField = value;
        }
    }
    
    /// <remarks/>
    public string CodigoMunicipio {
        get {
            return this.codigoMunicipioField;
        }
        set {
            this.codigoMunicipioField = value;
        }
    }
    
    /// <remarks/>
    public string NomeMunicipio {
        get {
            return this.nomeMunicipioField;
        }
        set {
            this.nomeMunicipioField = value;
        }
    }
    
    /// <remarks/>
    public TUf UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    public string CEP {
        get {
            return this.cEPField;
        }
        set {
            this.cEPField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TPolo {
    
    private string nomeField;
    
    private TEndereco enderecoField;
    
    private uint codigoEMECField;
    
    /// <remarks/>
    public string Nome {
        get {
            return this.nomeField;
        }
        set {
            this.nomeField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco Endereco {
        get {
            return this.enderecoField;
        }
        set {
            this.enderecoField = value;
        }
    }
    
    /// <remarks/>
    public uint CodigoEMEC {
        get {
            return this.codigoEMECField;
        }
        set {
            this.codigoEMECField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TAtoRegulatorio {
    
    private TTipoAto tipoField;
    
    private string numeroField;
    
    private System.DateTime dataField;
    
    private string veiculoPublicacaoField;
    
    private System.DateTime dataPublicacaoField;
    
    private bool dataPublicacaoFieldSpecified;
    
    private uint secaoPublicacaoField;
    
    private bool secaoPublicacaoFieldSpecified;
    
    private uint paginaPublicacaoField;
    
    private bool paginaPublicacaoFieldSpecified;
    
    /// <remarks/>
    public TTipoAto Tipo {
        get {
            return this.tipoField;
        }
        set {
            this.tipoField = value;
        }
    }
    
    /// <remarks/>
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime Data {
        get {
            return this.dataField;
        }
        set {
            this.dataField = value;
        }
    }
    
    /// <remarks/>
    public string VeiculoPublicacao {
        get {
            return this.veiculoPublicacaoField;
        }
        set {
            this.veiculoPublicacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DataPublicacao {
        get {
            return this.dataPublicacaoField;
        }
        set {
            this.dataPublicacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DataPublicacaoSpecified {
        get {
            return this.dataPublicacaoFieldSpecified;
        }
        set {
            this.dataPublicacaoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint SecaoPublicacao {
        get {
            return this.secaoPublicacaoField;
        }
        set {
            this.secaoPublicacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SecaoPublicacaoSpecified {
        get {
            return this.secaoPublicacaoFieldSpecified;
        }
        set {
            this.secaoPublicacaoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint PaginaPublicacao {
        get {
            return this.paginaPublicacaoField;
        }
        set {
            this.paginaPublicacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PaginaPublicacaoSpecified {
        get {
            return this.paginaPublicacaoFieldSpecified;
        }
        set {
            this.paginaPublicacaoFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TTipoAto {
    
    /// <remarks/>
    Parecer,
    
    /// <remarks/>
    Resolução,
    
    /// <remarks/>
    Decreto,
    
    /// <remarks/>
    Portaria,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Lei Federal")]
    LeiFederal,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Lei Estadual")]
    LeiEstadual,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Lei Municipal")]
    LeiMunicipal,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosIesEmissora {
    
    private string nomeField;
    
    private uint codigoMECField;
    
    private string cNPJField;
    
    private TEndereco enderecoField;
    
    private TAtoRegulatorio credenciamentoField;
    
    private TAtoRegulatorio recredenciamentoField;
    
    private TAtoRegulatorio renovacaoDeRecredenciamentoField;
    
    private TDadosIesEmissoraMantenedora mantenedoraField;
    
    /// <remarks/>
    public string Nome {
        get {
            return this.nomeField;
        }
        set {
            this.nomeField = value;
        }
    }
    
    /// <remarks/>
    public uint CodigoMEC {
        get {
            return this.codigoMECField;
        }
        set {
            this.codigoMECField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco Endereco {
        get {
            return this.enderecoField;
        }
        set {
            this.enderecoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Credenciamento {
        get {
            return this.credenciamentoField;
        }
        set {
            this.credenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Recredenciamento {
        get {
            return this.recredenciamentoField;
        }
        set {
            this.recredenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio RenovacaoDeRecredenciamento {
        get {
            return this.renovacaoDeRecredenciamentoField;
        }
        set {
            this.renovacaoDeRecredenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TDadosIesEmissoraMantenedora Mantenedora {
        get {
            return this.mantenedoraField;
        }
        set {
            this.mantenedoraField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosIesEmissoraMantenedora {
    
    private string razaoSocialField;
    
    private string cNPJField;
    
    private TEndereco enderecoField;
    
    /// <remarks/>
    public string RazaoSocial {
        get {
            return this.razaoSocialField;
        }
        set {
            this.razaoSocialField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco Endereco {
        get {
            return this.enderecoField;
        }
        set {
            this.enderecoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosRegistro {
    
    private TDadosIesRegistradora iesRegistradoraField;
    
    private TLivroRegistro livroRegistroField;
    
    private string idDocumentacaoAcademicaField;
    
    private TSeguranca segurancaField;
    
    private SignatureType[] signatureField;
    
    private string idField;
    
    /// <remarks/>
    public TDadosIesRegistradora IesRegistradora {
        get {
            return this.iesRegistradoraField;
        }
        set {
            this.iesRegistradoraField = value;
        }
    }
    
    /// <remarks/>
    public TLivroRegistro LivroRegistro {
        get {
            return this.livroRegistroField;
        }
        set {
            this.livroRegistroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="ID")]
    public string IdDocumentacaoAcademica {
        get {
            return this.idDocumentacaoAcademicaField;
        }
        set {
            this.idDocumentacaoAcademicaField = value;
        }
    }
    
    /// <remarks/>
    public TSeguranca Seguranca {
        get {
            return this.segurancaField;
        }
        set {
            this.segurancaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType[] Signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosIesRegistradora {
    
    private string nomeField;
    
    private uint codigoMECField;
    
    private string cNPJField;
    
    private TEndereco enderecoField;
    
    private TAtoRegulatorio credenciamentoField;
    
    private TAtoRegulatorio recredenciamentoField;
    
    private TAtoRegulatorio renovacaoDeRecredenciamentoField;
    
    private TDadosIesRegistradoraMantenedora mantenedoraField;
    
    /// <remarks/>
    public string Nome {
        get {
            return this.nomeField;
        }
        set {
            this.nomeField = value;
        }
    }
    
    /// <remarks/>
    public uint CodigoMEC {
        get {
            return this.codigoMECField;
        }
        set {
            this.codigoMECField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco Endereco {
        get {
            return this.enderecoField;
        }
        set {
            this.enderecoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Credenciamento {
        get {
            return this.credenciamentoField;
        }
        set {
            this.credenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio Recredenciamento {
        get {
            return this.recredenciamentoField;
        }
        set {
            this.recredenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TAtoRegulatorio RenovacaoDeRecredenciamento {
        get {
            return this.renovacaoDeRecredenciamentoField;
        }
        set {
            this.renovacaoDeRecredenciamentoField = value;
        }
    }
    
    /// <remarks/>
    public TDadosIesRegistradoraMantenedora Mantenedora {
        get {
            return this.mantenedoraField;
        }
        set {
            this.mantenedoraField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TDadosIesRegistradoraMantenedora {
    
    private string razaoSocialField;
    
    private string cNPJField;
    
    private TEndereco enderecoField;
    
    /// <remarks/>
    public string RazaoSocial {
        get {
            return this.razaoSocialField;
        }
        set {
            this.razaoSocialField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco Endereco {
        get {
            return this.enderecoField;
        }
        set {
            this.enderecoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TLivroRegistro {
    
    private string livroRegistroField;
    
    private string numeroFolhaDoDiplomaField;
    
    private string numeroSequenciaDoDiplomaField;
    
    private string processoDoDiplomaField;
    
    private System.DateTime dataColacaoGrauField;
    
    private System.DateTime dataExpedicaoDiplomaField;
    
    private System.DateTime dataRegistroDiplomaField;
    
    private TLivroRegistroResponsavelRegistro responsavelRegistroField;
    
    /// <remarks/>
    public string LivroRegistro {
        get {
            return this.livroRegistroField;
        }
        set {
            this.livroRegistroField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroFolhaDoDiploma {
        get {
            return this.numeroFolhaDoDiplomaField;
        }
        set {
            this.numeroFolhaDoDiplomaField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroSequenciaDoDiploma {
        get {
            return this.numeroSequenciaDoDiplomaField;
        }
        set {
            this.numeroSequenciaDoDiplomaField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessoDoDiploma {
        get {
            return this.processoDoDiplomaField;
        }
        set {
            this.processoDoDiplomaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DataColacaoGrau {
        get {
            return this.dataColacaoGrauField;
        }
        set {
            this.dataColacaoGrauField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DataExpedicaoDiploma {
        get {
            return this.dataExpedicaoDiplomaField;
        }
        set {
            this.dataExpedicaoDiplomaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DataRegistroDiploma {
        get {
            return this.dataRegistroDiplomaField;
        }
        set {
            this.dataRegistroDiplomaField = value;
        }
    }
    
    /// <remarks/>
    public TLivroRegistroResponsavelRegistro ResponsavelRegistro {
        get {
            return this.responsavelRegistroField;
        }
        set {
            this.responsavelRegistroField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TLivroRegistroResponsavelRegistro {
    
    private string nomeField;
    
    private string cPFField;
    
    private string iDouNumeroMatriculaField;
    
    /// <remarks/>
    public string Nome {
        get {
            return this.nomeField;
        }
        set {
            this.nomeField = value;
        }
    }
    
    /// <remarks/>
    public string CPF {
        get {
            return this.cPFField;
        }
        set {
            this.cPFField = value;
        }
    }
    
    /// <remarks/>
    public string IDouNumeroMatricula {
        get {
            return this.iDouNumeroMatriculaField;
        }
        set {
            this.iDouNumeroMatriculaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public partial class TSeguranca {
    
    private string codigoValidacaoField;
    
    /// <remarks/>
    public string CodigoValidacao {
        get {
            return this.codigoValidacaoField;
        }
        set {
            this.codigoValidacaoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://portal.mec.gov.br/diplomadigital/arquivos-em-xsd")]
public enum TVersao {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1.00")]
    Item100,
}
