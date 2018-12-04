
# react-native-life-fitness

## Getting started

`$ npm install react-native-life-fitness --save`

### Mostly automatic installation

`$ react-native link react-native-life-fitness`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-life-fitness` and add `RNLifeFitness.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLifeFitness.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLifeFitnessPackage;` to the imports at the top of the file
  - Add `new RNLifeFitnessPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-life-fitness'
  	project(':react-native-life-fitness').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-life-fitness/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-life-fitness')
  	```

## Usage
```javascript
import RNLifeFitness from 'react-native-life-fitness';

// TODO: What to do with the module?
RNLifeFitness;
```
  