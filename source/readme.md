# Library Template

*   projects

    *   remove/delete unneeded projects

*   Bindings projects

    *   remove them if bindings are not used

    *   platforms

        *   Xamarin.Android  (new style, short style, SDK style projects)

            `ProjectTemplate.Bindings.XamarinAndroid`

        *   Xamarin.Android (old style, long style, non SDK style projects)

            `ProjectTemplate.Bindings.XamarinAndroid.OldNonSDKStyle`

        *   Xamarin.iOS (new style, short style, SDK style projects)

            `ProjectTemplate.Bindings.XamarinIOS`

        *   Xamarin.iOS (old style, long style, non SDK style projects)

            `ProjectTemplate.Bindings.XamarinIOS.OldNonSDKStyle`

        *   netstandard library for *bindings* common API abstractions (like Xamarin.Forms or Xamarin.Essentials)

            `ProjectTemplate.Bindings.netstandard10`

*   Library (API) projects

    * reference Bindings projects if neccessary

        *   netstandard library for common API abstractions (like Xamarin.Forms or Xamarin.Essentials)

            `ProjectTemplate.netstandard10`

        *   shared library for common API abstractions (like Xamarin.Forms or Xamarin.Essentials)

            `ProjectTemplate.Shared`

        *   Xamarin.Android platform specific library code

            `ProjectTemplate.XamarinAndroid`

        *   Xamarin.Android platform specific library code

            `ProjectTemplate.XamarinIOS`

## TODO (planed)

*   UWP

    *   Sasa Bajtl

*   Xamarin.Mac

*   C bindings

*   C++ bindings