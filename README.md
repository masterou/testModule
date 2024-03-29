
# react-native-test-module

## Getting started

`$ npm install react-native-test-module --save`

### Mostly automatic installation

`$ react-native link react-native-test-module`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-test-module` and add `RNTestModule.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNTestModule.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNTestModulePackage;` to the imports at the top of the file
  - Add `new RNTestModulePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-test-module'
  	project(':react-native-test-module').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-test-module/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-test-module')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNTestModule.sln` in `node_modules/react-native-test-module/windows/RNTestModule.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Test.Module.RNTestModule;` to the usings at the top of the file
  - Add `new RNTestModulePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNTestModule from 'react-native-test-module';

// TODO: What to do with the module?
RNTestModule;
```
  