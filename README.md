# Unity Supplements

## Global

### Extensions
- [Array1](./Global/Extensions/Array1Extensions.cs)
- [Number](./Global/Extensions/NumberExtensions.cs)
- [String](./Global/Extensions/StringExtensions.cs)

## System

### Delegate
- [ReadStructAction](./System/Delegates/ReadStructAction.cs)
- [ReadStructFunc](./System/Delegates/ReadStructFunc.cs)
- [ReadStructPredicate](./System/Delegates/ReadStructPredicate.cs)

### Interface
- [IComparableReadOnlyStruct\<T>](./System/Interfaces/IComparableReadOnlyStruct%7BT%7D.cs)
- [IEquatableReadOnlyStruct\<T>](./System/Interfaces/IEquatableReadOnlyStruct%7BT%7D.cs)

### Index & Length
- [Index2](./System/Indices/Index2.cs)
- [Index3](./System/Indices/Index3.cs)
- [Index4](./System/Indices/Index4.cs)
- [Index5](./System/Indices/Index5.cs)
- [Length2](./System/Lengths/Length2.cs)
- [Length3](./System/Lengths/Length3.cs)
- [Length4](./System/Lengths/Length4.cs)
- [Length5](./System/Lengths/Length5.cs)

### Array
- [ReadArray1\<T>](./System/ReadArray1/ReadArray1%7BT%7D.cs)
- [ReadArray1\<T> extensions](./System/ReadArray1/ReadArray1TExtensions.cs)
- [Array1Pool\<T>](./System/Pools/Array1Pool%7BT%7D.cs)

### Enum
- [Enum\<T>](./System/Enum/Enum%7BT%7D.cs)
- [EnumIndex](./System/Enum/EnumIndex.cs)
- [EnumLength](./System/Enum/EnumLength.cs)
- [EnumRandomizer\<T>](./System/Randomizer/EnumRandomizer%7BT%7D.cs)

### Singleton
- [Singleton](./System/Singletons/Singleton.cs)
- [Singleton\<T>](./System/Singletons/Singleton%7BT%7D.cs)

### Pseudo Probability
- [PseudoProbability](./System/PseudoProbability/PseudoProbability.cs)
- [PseudoProbability.PRD](./System/PseudoProbability/PseudoProbability.PRD.cs)
- [PseudoProbability.IMath](./System/PseudoProbability/PseudoProbability.IMath.cs)
- [PseudoProbability.IRandom](./System/PseudoProbability/PseudoProbability.IRandom.cs)

### Range
- [IRange\<T>](./System/Range/IRange%7BT%7D.cs)
- [IRange\<TValue, TEnumerator>](./System/Range/IRange%7BTValue%2CTEnumerator%7D.cs)
- [IRangeEnumerator\<T>](./System/Range/IRangeEnumerator%7BT%7D.cs)
- [ReadRange\<T>](./System/Range/ReadRange%7BT%7D.cs)
- [ReadRange\<TValue, TEnumerator>](./System/Range/ReadRange%7BTValue%2CTEnumerator%7D.cs)
- [IntRange](./System/Range/IntRange.cs)
- [UIntRange](./System/Range/UIntRange.cs)

### Misc.
- [Converter](./System/Converter.cs)

## System.IO

- [FileSystem](./System.IO/FileSystem.cs)

## System.Runtime.Serialization.Formatters.Text

- [ITextFormatter](./System.Runtime.Serialization.Formatters.Text/ITextFormatter.cs)
- [ITextFormatter\<T>](./System.Runtime.Serialization.Formatters.Text/ITextFormatter%7BT%7D.cs)

## System.Collection.Generics

### Interface
- [IReadOnlyStructEqualityComparer\<T>](./System.Collections.Generic/IReadOnlyStructEqualityComparer%7BT%7D.cs)
- [IReadOnlyStructComparer\<T>](./System.Collections.Generic/IReadOnlyStructComparer%7BT%7D.cs)

### Extensions
- [Collection\<T>](./System.Collections.Generic/Extensions/CollectionTExtensions.cs)
- [IEnumerable\<T>](./System.Collections.Generic/Extensions/IEnumerableTExtensions.cs)
- [IEnumerator\<T>](./System.Collections.Generic/Extensions/IEnumeratorTExtensions.cs)
- [List\<T>](./System.Collections.Generic/Extensions/ListTExtensions.cs)
- [Dictionary\<TKey, TValue>](./System.Collections.Generic/Extensions/DictionaryTKeyTValueExtensions.cs)
- [Queue\<T>](./System.Collections.Generic/Extensions/QueueTExtensions.cs)
- [Stack\<T>](./System.Collections.Generic/Extensions/StackTExtensions.cs)

### Segment
- [ISegment\<T>](./System.Collections.Generic/Segments/Interfaces/ISegment.cs)
- [ISegmentReader\<T>](./System.Collections.Generic/Segments/Interfaces/ISegmentReader.cs)
- [ISegmentSource\<T>](./System.Collections.Generic/Segments/Interfaces/ISegmentSource.cs)
- [Segment\<T>](./System.Collections.Generic/Segments/Segment/Segment.cs)
- [Segment1\<T>](./System.Collections.Generic/Segments/Segment1.cs)
- [Array1Segment\<T>](./System.Collections.Generic/Segments/Array1Segment.cs)
- [ListSegment\<T>](./System.Collections.Generic/Segments/ListSegment.cs)
- [StringSegment](./System.Collections.Generic/Segments/StringSegment/StringSegment.cs)
- [SegmentReader\<TSegment, TValue>](./System.Collections.Generic/Segments/SegmentReader.cs)
- [Extensions](./System.Collections.Generic/Segments/Extensions)

### Read-Only Collection
- [ReadCollection\<T>](./System.Collections.Generic/ReadCollections/ReadCollection%7BT%7D.cs)
- [ReadDictionary\<TKey, TValue>](./System.Collections.Generic/ReadCollections/ReadDictionary%7BTKey%2CTValue%7D.cs)
- [ReadList\<T>](./System.Collections.Generic/ReadCollections/ReadList%7BT%7D.cs)
- [Extensions](./System.Collections.Generic/ReadCollections/Extensions)

### Randomizer
- [Randomizer](./System.Collections.Generic/Randomizer/Randomizer.cs)
- [Randomizer.IRandom](./System.Collections.Generic/Randomizer/Randomizer.IRandom.cs)
- [Randomizer.ICache\<T>](./System.Collections.Generic/Randomizer/Randomizer.Cache%7BT%7D.cs)

### Pool
- [IPool\<T>](./System.Collections.Generic/Pools/IPool%7BT%7D.cs)
- [Pool\<T>](./System.Collections.Generic/Pools/Pool%7BT%7D.cs)
- [ListPool\<T>](./System.Collections.Generic/Pools/ListPool%7BT%7D.cs)
- [DictionaryPool\<TKey, TValue>](./System.Collections.Generic/Pools/DictionaryPool%7BTKey%2CTValue%7D.cs)
- [HashSetPool\<T>](./System.Collections.Generic/Pools/HashSetPool%7BT%7D.cs)
- [QueuePool\<T>](./System.Collections.Generic/Pools/QueuePool%7BT%7D.cs)
- [StackPool\<T>](./System.Collections.Generic/Pools/StackPool%7BT%7D.cs)

### Misc.
- [EnumValues\<T>](./System.Collections.Generic/EnumValues.cs)

## System.Collection.Concurrent

### Pool
- [ConcurrentPool\<T>](./System.Collections.Concurrent/Pools/ConcurrentPool%7BT%7D.cs)
- [ListConcurrentPool\<T>](./System.Collections.Concurrent/Pools/ListConcurrentPool%7BT%7D.cs)
- [DictionaryConcurrentPool\<TKey, TValue>](./System.Collections.Concurrent/Pools/DictionaryConcurrentPool%7BTKey%2CTValue%7D.cs)
- [HashSetConcurrentPool\<T>](./System.Collections.Concurrent/Pools/HashSetConcurrentPool%7BT%7D.cs)
- [QueueConcurrentPool\<T>](./System.Collections.Concurrent/Pools/QueueConcurrentPool%7BT%7D.cs)
- [StackConcurrentPool\<T>](./System.Collections.Concurrent/Pools/StackConcurrentPool%7BT%7D.cs)
- [ConcurrentPool\<T>](./System.Collections.Concurrent/Pools/ConcurrentBagPool%7BT%7D.cs)
- [ConcurrentDictionaryPool\<TKey, TValue>](./System.Collections.Concurrent/Pools/ConcurrentDictionaryPool%7BTKey%2CTValue%7D.cs)
- [ConcurrentQueuePool\<T>](./System.Collections.Concurrent/Pools/ConcurrentQueuePool%7BT%7D.cs)
- [ConcurrentStackPool\<T>](./System.Collections.Concurrent/Pools/ConcurrentStackPool%7BT%7D.cs)

## System.Fluent

- [ObjectExtensions.FluentDelegates](./System.Fluent/Extensions/ObjectExtensions.FluentDelegates.cs)

## System.Grid

- [GridIndex](./System.Grid/GridIndex.cs)
- [GridIndexRange](./System.Grid/GridIndexRange.cs)
- [GridRange](./System.Grid/GridRange.cs)
- [GridSize](./System.Grid/GridSize.cs)
- [ClampedGridSize](./System.Grid/ClampedGridSize.cs)
- [GridValue\<T>](./System.Grid/GridValue%7BT%7D.cs)
- [IGridValues\<T>](./System.Grid/IGridValues%7BT%7D.cs)
- [IGridValueEnumerator\<T>](./System.Grid/IGridValueEnumerator%7BT%7D.cs)
- [IGridIndexedValues\<T>](./System.Grid/IGridIndexedValues%7BT%7D.cs)
- [IGridIndexedValueEnumerator\<T>](./System.Grid/IGridIndexedValueEnumerator%7BT%7D.cs)
- [IReadOnlyGrid\<T>](./System.Grid/IReadOnlyGrid%7BT%7D.cs)
- [IGrid\<T>](./System.Grid/IGrid%7BT%7D.cs)
- [Grid\<T>](./System.Grid/Grid%7BT%7D.cs)
- [Grid\<T>.GridValues](./System.Grid/Grid%7BT%7D.GridValues.cs)
- [Grid\<T>.GridIndexedValues](./System.Grid/Grid%7BT%7D.GridIndexedValues.cs)
- [ReadGrid\<T>](./System.Grid/ReadGrid%7BT%7D.cs)

## System.Table

- [IEntry](./System.Table/IEntry.cs)
- [IGetId](./System.Table/IGetId.cs)
- [ITable](./System.Table/ITable.cs)
- [Table](./System.Table/Table.cs)
- [ReadEntry](./System.Table/ReadEntry.cs)
- [ReadTable](./System.Table/ReadTable.cs)

## UnityEngine

### Collection
- [SerializableDictionary\<TKey, TValue>](./UnityEngine/SerializableDictionary.cs)

### Singleton
- [SingletonBehaviour\<T>](./UnityEngine/SingletonBehaviour.cs)

### Extensions
- [BoundsExtensions](./UnityEngine/Extensions/BoundsExtensions.cs)
- [ColorExtensions](./UnityEngine/Extensions/ColorExtensions.cs)
- [MatrixExtenions](./UnityEngine/Extensions/MatrixExtensions.cs)
- [QuaternionExtensions](./UnityEngine/Extensions/QuaternionExtensions.cs)
- [RangeExtensions](./UnityEngine/Extensions/RangeExtensions.cs)
- [RayExtensions](./UnityEngine/Extensions/RayExtensions.cs)
- [RectExtensions](./UnityEngine/Extensions/RectExtensions.cs)
- [ResolutionExtensions](./UnityEngine/Extensions/ResolutionExtensions.cs)
- [VectorExtensions](./UnityEngine/Extensions/VectorExtensions.cs)

### Misc.
- [HSBColor](./UnityEngine/HSBColor.cs)
- [LEBColor](./UnityEngine/LEBColor.cs)
- [Offset](./UnityEngine/Offset.cs)
- [OffsetInt](./UnityEngine/OffsetInt.cs)
- [ScreenResolution](./UnityEngine/ScreenResolution.cs)
- [Size](./UnityEngine/Size.cs)
- [SizeInt](./UnityEngine/SizeInt.cs)
- [SingleLayer](./UnityEngine/SingleLayer.cs)
- [SortingLayerId](./UnityEngine/SortingLayerId.cs)
- [GridVector](./UnityEngine/GridVector.cs)

## Unity.Collections

- [ReadNativeArray\<T>](./Unity.Collections/Segments/NativeArray/ReadNativeArray%7BT%7D.cs)
- [ReadNativeSlice\<T>](./Unity.Collections/Segments/NativeSlice/ReadNativeSlice%7BT%7D.cs)
- [NativeArraySegment\<T>](./Unity.Collections/Segments/NativeArray/NativeArraySegment.cs)
- [NativeSliceSegment\<T>](./Unity.Collections/Segments/NativeSlice/NativeSliceSegment.cs)
- [Extensions](./Unity.Collections/Segments/Extensions/NativeSegmentExtensions.cs)

## UnityEditor
- [SingleLayerDrawer](./Editor/UnityEngine/SingleLayerDrawer.cs)
- [SortingLayerIdDrawer](./Editor/UnityEngine/SortingLayerIdDrawer.cs)
- [GridVectorDrawer](./Editor/UnityEngine/GridVectorDrawer.cs)
