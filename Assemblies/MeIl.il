.assembly MeILAssembly {}

.assembly extern mscorlib {}

.class public MeIlClass extends [mscorlib]System.Object {
	.method public static void MeIlMethod() cil managed {
		ldstr "howdy from IL"
		call void [mscorlib]System.Console::WriteLine(string)
		ret
	}
}