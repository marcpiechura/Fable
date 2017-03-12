﻿module Fable.Tests.Main

// This is necessary to make webpack collect all test files

#if FABLE_COMPILER
open Fable.Core.JsInterop
importAll "./ApplicativeTests.fs"
importAll "./ArithmeticTests.fs"
importAll "./ArrayTests.fs"
importAll "./AsyncTests.fs"
importAll "./ComparisonTests.fs"
importAll "./ConvertTests.fs"
importAll "./DateTimeTests.fs"
importAll "./DictionaryTests.fs"
importAll "./EnumerableTests.fs"
importAll "./EnumTests.fs"
importAll "./EventTests.fs"
importAll "./HashSetTests.fs"
importAll "./ImportTests.fs"
importAll "./JsInteropTests.fs"
importAll "./JsonTests.fs"
importAll "./ListTests.fs"
importAll "./MapTests.fs"
importAll "./MiscTests.fs"
importAll "./ObservableTests.fs"
importAll "./RecordTypeTests.fs"
importAll "./ReflectionTests.fs"
importAll "./RegexTests.fs"
importAll "./ResizeArrayTests.fs"
importAll "./SeqExpressionTests.fs"
importAll "./SeqTests.fs"
importAll "./SetTests.fs"
importAll "./StringTests.fs"
importAll "./SudokuTest.fs"
importAll "./TailCallTests.fs"
importAll "./TupleTypeTests.fs"
importAll "./TypeTests.fs"
importAll "./UnionTypeTests.fs"
#endif