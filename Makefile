run:
	dmcs -target:library SuecaMessages/SuecaMessages.cs -reference:../SERA_1-12-2015/Binaries/Thalamus/Thalamus.dll -out:SuecaMessages/bin/Debug/SuecaMessages.dll 
	dmcs -target:library SuecaTypes/Card.cs SuecaTypes/JsonSerializable.cs -reference:../SERA_1-12-2015/Binaries/Thalamus/Newtonsoft.Json.dll -out:SuecaTypes/bin/Debug/SuecaTypes.dll 
