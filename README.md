# Dotnet new template of the Xamarin Components team

This is folder structure used by Xamarin Components team:


*   source
    
    bindings libraries and/or cross platform libraries with extensions

    NOTE: assembly-names and namespaces are prepared for nuget bait-n-switch

*   samples

    Samples for the libraries

*   tests

    *   unit tests

    *   ui tests




## Structure

    ├── External-Dependency-Info.txt
    ├── LICENSE.md
    ├── build.cake
    ├── docs
    ├── nuget
    │   └── HolisticWare.XamarinProjectsStructureTemplate.nuspec
    ├── readme.md
    ├── samples
    │   ├── XamarinProjectsStructureTemplate.Sample.XamarinAndroid
    │   │   ├── Assets
    │   │   │   └── AboutAssets.txt
    │   │   ├── MainActivity.cs
    │   │   ├── Properties
    │   │   │   ├── AndroidManifest.xml
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Resources
    │   │   │   ├── AboutResources.txt
    │   │   │   ├── Resource.designer.cs
    │   │   │   ├── drawable
    │   │   │   ├── layout
    │   │   │   │   └── Main.axml
    │   │   │   ├── mipmap-hdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-mdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xhdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xxhdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xxxhdpi
    │   │   │   │   └── Icon.png
    │   │   │   └── values
    │   │   │       └── Strings.xml
    │   │   ├── XamarinProjectsStructureTemplate.Sample.XamarinAndroid.csproj
    │   │   ├── XamarinProjectsStructureTemplate.Sample.XamarinAndroid.csproj.user
    │   │   └── packages.config
    │   ├── XamarinProjectsStructureTemplate.Sample.XamarinIOS
    │   │   ├── AppDelegate.cs
    │   │   ├── Assets.xcassets
    │   │   │   ├── AppIcon.appiconset
    │   │   │   │   └── Contents.json
    │   │   │   ├── Contents.json
    │   │   │   ├── First.imageset
    │   │   │   │   ├── Contents.json
    │   │   │   │   └── vector.pdf
    │   │   │   └── Second.imageset
    │   │   │       ├── Contents.json
    │   │   │       └── vector.pdf
    │   │   ├── Entitlements.plist
    │   │   ├── FirstViewController.cs
    │   │   ├── FirstViewController.designer.cs
    │   │   ├── Info.plist
    │   │   ├── LaunchScreen.storyboard
    │   │   ├── Main.cs
    │   │   ├── Main.storyboard
    │   │   ├── Resources
    │   │   ├── SecondViewController.cs
    │   │   ├── SecondViewController.designer.cs
    │   │   ├── XamarinProjectsStructureTemplate.Sample.XamarinIOS.csproj
    │   │   └── packages.config
    │   └── XamarinProjectsStructureTemplate.Samples.sln
    ├── source
    │   ├── XamarinProjectsStructureTemplate.Bindings.NetStandard10
    │   │   └── XamarinProjectsStructureTemplate.Bindings.NetStandard10.csproj
    │   ├── XamarinProjectsStructureTemplate.Bindings.XamarinAndroid
    │   │   ├── Additions
    │   │   │   └── AboutAdditions.txt
    │   │   ├── Jars
    │   │   │   └── AboutJars.txt
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Transforms
    │   │   │   ├── EnumFields.xml
    │   │   │   ├── EnumMethods.xml
    │   │   │   └── Metadata.xml
    │   │   └── XamarinProjectsStructureTemplate.Bindings.XamarinAndroid.csproj
    │   ├── XamarinProjectsStructureTemplate.Bindings.XamarinIOS
    │   │   ├── ApiDefinition.cs
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Structs.cs
    │   │   └── XamarinProjectsStructureTemplate.Bindings.XamarinIOS.csproj
    │   ├── XamarinProjectsStructureTemplate.NetStandard10
    │   │   └── XamarinProjectsStructureTemplate.NetStandard10.csproj
    │   ├── XamarinProjectsStructureTemplate.Source.sln
    │   ├── XamarinProjectsStructureTemplate.XamarinAndroid
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Resources
    │   │   │   ├── AboutResources.txt
    │   │   │   ├── Resource.designer.cs
    │   │   │   └── values
    │   │   │       └── Strings.xml
    │   │   └── XamarinProjectsStructureTemplate.XamarinAndroid.csproj
    │   └── XamarinProjectsStructureTemplate.XamarinIOS
    │       ├── Properties
    │       │   └── AssemblyInfo.cs
    │       ├── Resources
    │       └── XamarinProjectsStructureTemplate.XamarinIOS.csproj
    └── tests
        ├── ui-tests
        │   ├── XamarinProjectsStructureTemplate.Sample.XamarinAndroid.UITests
        │   │   ├── Tests.cs
        │   │   ├── XamarinProjectsStructureTemplate.Sample.XamarinAndroid.UITests.csproj
        │   │   └── packages.config
        │   ├── XamarinProjectsStructureTemplate.Sample.XamarinIOS.UITests
        │   │   ├── Tests.cs
        │   │   ├── XamarinProjectsStructureTemplate.Sample.XamarinIOS.UITests.csproj
        │   │   └── packages.config
        │   └── XamarinProjectsStructureTemplate.UITests.sln
        └── unit-tests
            └── XamarinProjectsStructureTemplate.UnitTests.sln
