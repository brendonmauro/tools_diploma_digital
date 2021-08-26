# tools_diploma_digital
Repositório destinado a compartilhar ferramentas que facilitaram a implementação do diploma digital. É importante salientar que este repositório jamais terá código ou qualquer implementação específica a alguma instituição acadêmica.



Como é feita a geração de classes XSD para a linguagem de programação C#:

1 - Abrir cmd

2 - Caminhar até a pasta(pode ser que a versão seja diferente [v10.0, netfx 4.8, etc~]):
     cd C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\
     
3 - Próximo passo Doc academica (coloquei meus arquivos na pasta dev):
    xsd C:\Dev\tiposBasicos_v1.02.xsd C:\Dev\xmldsig-core-schema_v1.1.xsd  C:\Dev\leiauteDocumentacaoAcademicaRegistroDiplomaDigital_v1.02.xsd C:\Dev\DocumentacaoAcademicaRegistroDiplomaDigital_v1.02.xsd /c /l:CS /o:C:\Dev

4 - Próximo passo Diploma digital (coloquei meus arquivos na pasta dev):
  xsd C:\Dev\tiposBasicos_v1.02.xsd C:\Dev\xmldsig-core-schema_v1.1.xsd  C:\Dev\leiauteDiplomaDigital_v1.02.xsd C:\Dev\DiplomaDigital_v1.02.xsd /c /l:CS /o:C:\Dev

Referência:
https://www.youtube.com/watch?v=QHJTdebvNPQ
