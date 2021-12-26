Imports System

Namespace Searcher.Parser
	Friend Class GetInfo
		Public Google As String = "Links: A" & VbCrLf & "Insistence to proxy: hard" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 1500+" & VbCrLf & "TimeOut: 15000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 30-50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 1" & VbCrLf & "Links: ~30-50k" & VbCrLf & ""

		Public Bing As String = "Links: C" & VbCrLf & "Insistence to proxy: none" & VbCrLf & "Thread: 50+" & VbCrLf & "Proxy: 0+" & VbCrLf & "TimeOut: 5000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 100" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 30" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Yahoo As String = "Links: B" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 300+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 100" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 1" & VbCrLf & "Links: ~30-50k" & VbCrLf & ""

		Public AOL As String = "Links: C" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 150+" & VbCrLf & "Proxy: 300+" & VbCrLf & "TimeOut: 7000" & VbCrLf & "Ban: 1 thread - No,if > 1 - Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 1" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Teoma As String = "Links: D" & VbCrLf & "Insistence to proxy: very light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 20-50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 1-3" & VbCrLf & "Links: ~70-120k" & VbCrLf & ""

		Public Ask As String = "Links: F" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 0+" & VbCrLf & "TimeOut: 7000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Orange As String = "Links: C" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 50+" & VbCrLf & "Proxy: 300+" & VbCrLf & "TimeOut: 7000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 30" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 1" & VbCrLf & "Links: ~10-15k" & VbCrLf & ""

		Public WOW As String = "Links: D" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 0+" & VbCrLf & "TimeOut: 7000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: many" & VbCrLf & ""

		Public MyWebSearch As String = "Links: C" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: many" & VbCrLf & ""

		Public [GoTo] As String = "Links: C" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 5000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 10" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Search As String = "Links: D" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 8000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: any" & VbCrLf & "Links: low" & VbCrLf & ""

		Public Hotbot As String = "Links: C" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 15000" & VbCrLf & "Ban: DDOS protect" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 10" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 1-10" & VbCrLf & "Links: medium" & VbCrLf & ""

		Public StartPage As String = "Links: D" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 10-25" & VbCrLf & "TimerOut: 15000" & VbCrLf & "Page: 1" & VbCrLf & "Links: medium" & VbCrLf & ""

		Public ZenSearch As String = "Links: C" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 8000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 30" & VbCrLf & "Links: medium" & VbCrLf & ""

		Public Bravica As String = "TEST!!!" & VbCrLf & "Links: B" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 8000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 30" & VbCrLf & "Links: medium" & VbCrLf & ""

		Public Rambler As String = "Links: A" & VbCrLf & "Insistence to proxy: medium" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 8000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: 5" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Nigma As String = "Links: C" & VbCrLf & "Insistence to proxy: hard" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 500+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: N/A" & VbCrLf & "TimerOut: 5000" & VbCrLf & "Page: N/A" & VbCrLf & "Links: low" & VbCrLf & ""

		Public Yandex As String = "Links: A" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 10000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 100+" & VbCrLf & "TimerOut: 10000" & VbCrLf & "Page: N/A" & VbCrLf & "Links: ~10k" & VbCrLf & ""

		Public Mail As String = "Links: C" & VbCrLf & "Insistence to proxy: hard" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 500+" & VbCrLf & "TimeOut: 15000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: N/A" & VbCrLf & "TimerOut: N/A" & VbCrLf & "Page: N/A" & VbCrLf & "Links: N/A" & VbCrLf & ""

		Public Amazon As String = "Links: B" & VbCrLf & "Insistence to proxy: None" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 0+" & VbCrLf & "TimeOut: 10000-15000" & VbCrLf & "Ban: No" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50+" & VbCrLf & "TimerOut: 10000" & VbCrLf & "Page: 30" & VbCrLf & "Links: many" & VbCrLf & ""

		Public Ecosia As String = "Links: C" & VbCrLf & "Insistence to proxy: light" & VbCrLf & "Thread: 100+" & VbCrLf & "Proxy: 100+" & VbCrLf & "TimeOut: 10000-15000" & VbCrLf & "Ban: Yes" & VbCrLf & "" & VbCrLf & "Recommendations, without Proxy:" & VbCrLf & "Thread: 50+" & VbCrLf & "TimerOut: 7000" & VbCrLf & "Page: 1" & VbCrLf & "Links: low" & VbCrLf & ""

		Public Sub New()
			MyBase.New()
		End Sub
	End Class
End Namespace