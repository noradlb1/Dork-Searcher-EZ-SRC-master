Imports System
Imports System.Collections.Generic

Namespace Searcher.Parser.Setting.HelpDopSetting
	Friend Class language
		Private DBlang As Dictionary(Of String, String)

        Public Sub New()
            Me.DBlang = New Dictionary(Of String, String)() From
            {
                {"(Afan) Oromo", "om"},
                {"Abkhazian", "ab"},
                {"Afar", "aa"},
                {"Afrikaans", "af"},
                {"Albanian", "sq"},
                {"Amharic", "am"},
                {"Arabic", "ar"},
                {"Armenian", "hy"},
                {"Assamese", "as"},
                {"Aymara", "ay"},
                {"Azerbaijani", "az"},
                {"Bashkir", "ba"},
                {"Basque", "eu"},
                {"Bengali", "bn"},
                {"Bhutani", "dz"},
                {"Bihari", "bh"},
                {"Bislama", "bi"},
                {"Breton", "br"},
                {"Bulgarian", "bg"},
                {"Burmese", "my"},
                {"Byelorussian", "be"},
                {"Cambodian", "km"},
                {"Catalan", "ca"},
                {"Chinese", "zh"},
                {"Corsican", "co"},
                {"Croatian", "hr"},
                {"Czech", "cs"},
                {"Danish", "da"},
                {"Dutch", "nl"},
                {"English", "en"},
                {"Esperanto", "eo"},
                {"Estonian", "et"},
                {"Faeroese", "fo"},
                {"Fiji", "fj"},
                {"Finnish", "fi"},
                {"French", "fr"},
                {"Frisian", "fy"},
                {"Galician", "gl"},
                {"Georgian", "ka"},
                {"German", "de"},
                {"Greek", "el"},
                {"Greenlandic", "kl"},
                {"Guarani", "gn"},
                {"Gujarati", "gu"},
                {"Hausa", "ha"},
                {"Hebrew (former iw)", "he"},
                {"Hindi", "hi"},
                {"Hungarian", "hu"},
                {"Icelandic", "is"},
                {"Indonesian (former in)", "id"},
                {"Interlingua", "ia"},
                {"Interlingue", "ie"},
                {"Inupiak", "ik"},
                {"Inuktitut (Eskimo)", "iu"},
                {"Irish", "ga"},
                {"Italian", "it"},
                {"Japanese", "ja"},
                {"Javanese", "jw"},
                {"Kannada", "kn"},
                {"Kashmiri", "ks"},
                {"Kazakh", "kk"},
                {"Kinyarwanda", "rw"},
                {"Kirghiz", "ky"},
                {"Kirundi", "rn"},
                {"Korean", "ko"},
                {"Kurdish", "ku"},
                {"Laothian", "lo"},
                {"Latin", "la"},
                {"Latvian, Lettish", "lv"},
                {"Lingala", "ln"},
                {"Lithuanian", "lt"},
                {"Macedonian", "mk"},
                {"Malagasy", "mg"},
                {"Malay", "ms"},
                {"Malayalam", "ml"},
                {"Maltese", "mt"},
                {"Maori", "mi"},
                {"Marathi", "mr"},
                {"Moldavian", "mo"},
                {"Mongolian", "mn"},
                {"Nauru", "na"},
                {"Nepali", "ne"},
                {"Norwegian", "no"},
                {"Occitan", "oc"},
                {"Oriya", "or"},
                {"Pashto, Pushto", "ps"},
                {"Persian", "fa"},
                {"Polish", "pl"},
                {"Portuguese", "pt"},
                {"Punjabi", "pa"},
                {"Quechua", "qu"},
                {"Rhaeto-Romance", "rm"},
                {"Romanian", "ro"},
                {"Russian", "ru"},
                {"Samoan", "sm"},
                {"Sangro", "sg"},
                {"Sanskrit", "sa"},
                {"Scots Gaelic", "gd"},
                {"Serbian", "sr"},
                {"Serbo-Croatian", "sh"},
                {"Sesotho", "st"},
                {"Setswana", "tn"},
                {"Shona", "sn"},
                {"Sindhi", "sd"},
                {"Singhalese", "si"},
                {"Siswati", "ss"},
                {"Slovak", "sk"},
                {"Slovenian", "sl"},
                {"Somali", "so"},
                {"Spanish", "es"},
                {"Sudanese", "su"},
                {"Swahili", "sw"},
                {"Swedish", "sv"},
                {"Tagalog", "tl"},
                {"Tajik", "tg"},
                {"Tamil", "ta"},
                {"Tatar", "tt"},
                {"Tegulu", "te"},
                {"Thai", "th"},
                {"Tibetan", "bo"},
                {"Tigrinya", "ti"},
                {"Tonga", "to"},
                {"Tsonga", "ts"},
                {"Turkish", "tr"},
                {"Turkmen", "tk"},
                {"Twi", "tw"},
                {"Uigur", "ug"},
                {"Ukrainian", "uk"},
                {"Urdu", "ur"},
                {"Uzbek", "uz"},
                {"Vietnamese", "vi"},
                {"Volapuk", "vo"},
                {"Welch", "cy"},
                {"Wolof", "wo"},
                {"Xhosa", "xh"},
                {"Yiddish (former ji)", "yi"},
                {"Yoruba", "yo"},
                {"Zhuang", "za"},
                {"Zulu", "zu"}
            }
        End Sub

        Public Function GetLang(ByVal lang As String) As String
			Dim value As String
			Dim enumerator As Dictionary(Of String, String).Enumerator = Me.DBlang.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, String) = enumerator.Current
					If (current.Key <> lang) Then
						Continue While
					End If
					value = current.Value
					Return value
				End While
				Return ""
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function

		Public Function GetLangBing(ByVal lang As String) As String
			Dim value As String
			Dim enumerator As Dictionary(Of String, String).Enumerator = Me.DBlang.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, String) = enumerator.Current
					If (current.Key <> lang) Then
						Continue While
					End If
					value = current.Value
					Return value
				End While
				Return ""
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function
	End Class
End Namespace