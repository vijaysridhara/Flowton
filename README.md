# Flowton
# version 0.3
Flowton is a simple flowcharting application for developers, re-engineers, architects, database designers. 

![Screen](https://public-files.gumroad.com/8f54qwg4v4h4ehbrqx08avomb8yy)
It is based on NShape, which is a diagramming control for .net released by dataweb.de. 

## Supports the following features
1. Basic flow charting 
2. Electrical shapes
3. Software architecture shapes
4. General shapes and connectors
5. Multiple page diagrams
6. Print preview and Print
7. Export to jpg,png,bmp,emf

## Pre requisites:

1. Windows 10 or 11
2. .NET Framework 4.0 or 4.8
3. 4GB RAM and 10MB of diskspace

## Build Procedure
When you clone/download the code, it will not work as-is. You will need to download this project: https://github.com/dataweb-GmbH/NShape and build it Or its binaries 2.4
Next is to add the following references to the project Flowton
1. Dataweb.NShape.dll
2. Dataweb.NShape.WinFormsUI.dll 
3. Dataweb.NShape.ElectricalModelObjects.dll (Also copy to folder bin/Debug/Stencils)
4. Dataweb.NShape.ElectricalShapes.dll  (Also copy to folder bin/Debug/Stencils)
5. Dataweb.NShape.FlowChartShapes.dll (Also copy to folder bin/Debug/Stencils)
6. Dataweb.NShape.GeneralModelObjects.dll (Also copy to folder bin/Debug/Stencils)
7. Dataweb.NShape.GeneralShapes.dll (Also copy to folder bin/Debug/Stencils)
8. Dataweb.NShape.SoftwareArchitectureShapes.dll (Also copy to folder bin/Debug/Stencils)

The WinFormsUI gives the presentation layer, while the stencils are the libraries provided by NShape. If you are patient and skilled enough you can build your own tool using NShape, which is vast. 

Binaries: https://vijaysridhara.gumroad.com/l/flowton
