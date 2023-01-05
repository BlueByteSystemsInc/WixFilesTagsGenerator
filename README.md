# WixFilesTagsGenerator
Console tool to generate wix files tags for product.wxs


# How to use 
Provide a folder and the tool will generate the tags and ask you if you want to copy the text to the clipboard. Tool by default ignores solidworks pias

Example of generated output: 

```
<File Id='BlueByte.SOLIDWORKS.SDK.Core.dllID' Name='BlueByte.SOLIDWORKS.SDK.Core.dll'  Source ='$(var.SourceOutDir)\BlueByte.SOLIDWORKS.SDK.Core.dll'/>
<File Id='BlueByte.SOLIDWORKS.SDK.Core.pdbID' Name='BlueByte.SOLIDWORKS.SDK.Core.pdb'  Source ='$(var.SourceOutDir)\BlueByte.SOLIDWORKS.SDK.Core.pdb'/>
<File Id='BlueByte.SOLIDWORKS.SDK.dllID' Name='BlueByte.SOLIDWORKS.SDK.dll'  Source ='$(var.SourceOutDir)\BlueByte.SOLIDWORKS.SDK.dll'/>
<File Id='BlueByte.SOLIDWORKS.SDK.pdbID' Name='BlueByte.SOLIDWORKS.SDK.pdb'  Source ='$(var.SourceOutDir)\BlueByte.SOLIDWORKS.SDK.pdb'/>
<File Id='SimpleInjector.dllID' Name='SimpleInjector.dll'  Source ='$(var.SourceOutDir)\SimpleInjector.dll'/>
<File Id='SimpleInjector.xmlID' Name='SimpleInjector.xml'  Source ='$(var.SourceOutDir)\SimpleInjector.xml'/>
<File Id='SWSDK.TestAddIn.dllID' Name='SWSDK.TestAddIn.dll'  Source ='$(var.SourceOutDir)\SWSDK.TestAddIn.dll'/>
<File Id='SWSDK.TestAddIn.pdbID' Name='SWSDK.TestAddIn.pdb'  Source ='$(var.SourceOutDir)\SWSDK.TestAddIn.pdb'/>
<File Id='SWSDK.TestAddIn.tlbID' Name='SWSDK.TestAddIn.tlb'  Source ='$(var.SourceOutDir)\SWSDK.TestAddIn.tlb'/>
```

![image](https://user-images.githubusercontent.com/16106587/210859746-56640109-624f-4153-97e8-b8b70a7a86ec.png)
