Module Module1

    Dim myLaptop(5) As LaptopClass
    Dim myPhone(5) As MobilePhoneClass

    Dim LaptopCounter As Integer = 0
    Dim phoneCounter As Integer = 0

    Sub Main()
        Dim menuOption As Integer

        Do
            Call showOptions()
            Console.Write("Enter your option... ") : menuOption = Console.ReadLine
            Select Case menuOption
                Case 1 : Call addLaptop()
                Case 2 : Call addMobilePhone()
                Case 3 : Call displayLaptop()
                Case 4 : Call displayMobilePhone()
                Case 5 'exit program
                Case Else
                    Console.WriteLine("Invalid option entered...")
                    Console.ReadKey()
            End Select
        Loop Until menuOption = 5
    End Sub

    Sub showOptions()
        Console.Clear()
        Console.WriteLine("1. Add data to laptop")
        Console.WriteLine("2. Add data to mobile phone")
        Console.WriteLine("3. Display data of Laptop")
        Console.WriteLine("4. Display data of Mobile Phone")
        Console.WriteLine("5. Quit the program")
    End Sub

    Sub addLaptop()
        Dim C, M, P, RS, SS As String
        Dim Wid, H, Wei As Single
        Dim TS, RemScreen, TM As Boolean
        Dim U As Integer

        If LaptopCounter > 5 Then
            If LaptopCounter > 5 Then LaptopCounter = 5
            Console.WriteLine("Max 6 Laptops can be added. Limit exhausted...")
            Console.ReadKey()
            Exit Sub
        End If

        Do
            Console.Write("*Enter Code")
            C = Console.ReadLine
        Loop Until C <> ""

        Do
            Console.Write("*Enter Computer Width")
            Wid = Console.ReadLine
        Loop Until Wid >= 1 And Wid <= 4

        Do
            Console.Write("*Enter Height")
            H = Console.ReadLine
        Loop Until H >= 1 And H <= 6

        Do
            Console.Write("*Enter Computer Weight")
            Wei = Console.ReadLine
        Loop Until Wei >= 1 And Wei <= 4

        Do
            Console.Write("*Enter Make")
            M = Console.ReadLine
        Loop Until M <> ""

        Do
            Console.Write("*Enter Processor")
            P = Console.ReadLine
        Loop Until P <> ""

        Do
            Console.Write("*Enter RamSize")
            RS = Console.ReadLine
        Loop Until RS <> ""

        Do
            Console.Write("*Enter Storage Size")
            SS = Console.ReadLine
        Loop Until SS <> ""

        Console.Write("*Does Laptop have TouchScreen (Yes / No)")
        TS = Console.ReadLine

        Console.Write("*Does Laptop have RemovableScreen (Yes / No)")
        RemScreen = Console.ReadLine

        Console.Write("*Does Laptop have TabletMode (Yes / No)")
        TM = Console.ReadLine

        Console.Write("*How many USB 3.0 ports")
        U = Console.ReadLine

        myLaptop(LaptopCounter) = New LaptopClass(C, Wid, H, Wei, M, P, RS, SS, TS, RemScreen, TM, U)
        LaptopCounter += 1
    End Sub

    Sub addMobilePhone()
        Dim C, M, P, RS, SS, Net As String
        Dim Wid, H, Wei As Single
        Dim Cam, N3G, N4G As Boolean
        If phoneCounter > 5 Then
            If phoneCounter > 5 Then phoneCounter = 5
            Console.WriteLine("Max 6 Phones can be added. Limit exhausted...")
            Console.ReadKey()
            Exit Sub
        End If

        Do
            Console.Write("*Enter Code")
            C = Console.ReadLine
        Loop Until C <> ""

        Do
            Console.Write("*Enter Computer Width")
            Wid = Console.ReadLine
        Loop Until Wid >= 1 And Wid <= 4

        Do
            Console.Write("*Enter Height")
            H = Console.ReadLine
        Loop Until H >= 1 And H <= 6

        Do
            Console.Write("*Enter Computer Weight")
            Wei = Console.ReadLine
        Loop Until Wei >= 1 And Wei <= 4

        Do
            Console.Write("*Enter Make")
            M = Console.ReadLine
        Loop Until M <> ""

        Do
            Console.Write("*Enter Processor")
            P = Console.ReadLine
        Loop Until P <> ""

        Do
            Console.Write("*Enter RamSize")
            RS = Console.ReadLine
        Loop Until RS <> ""

        Do
            Console.Write("*Enter Storage Size")
            SS = Console.ReadLine
        Loop Until SS <> ""

        Console.Write("*Do Phone has a Camera ? (Yes / No)")
        Cam = Console.ReadLine

        Console.Write("*Do Phone Support 3g ? (Yes /No )")
        N3G = Console.ReadLine

        Console.Write("*Do Phone Support 4g ? (Yes /No )")
        N4G = Console.ReadLine

        Do
            Console.Write("*Enter Network")
            Net = Console.ReadLine
        Loop Until Net <> ""

        myPhone(phoneCounter) = New MobilePhoneClass(C, Wid, H, Wei, M, P, RS, SS, Cam, N3G, N4G, Net)
        phoneCounter += 1
    End Sub

    Sub displayLaptop()
        Dim a As Integer = 0
        Try
            For a = 0 To LaptopCounter
                Console.WriteLine("Code =" & myLaptop(a).getCode)
                Console.WriteLine("Computer Width = " & myLaptop(a).getComputerWidth)
                Console.WriteLine("Height  = " & myLaptop(a).getHeight)
                Console.WriteLine("Computer Weight = " & myLaptop(a).getComputerWidth)
                Console.WriteLine("Make = " & myLaptop(a).getMake)
                Console.WriteLine("Processor = " & myLaptop(a).getProcessor)
                Console.WriteLine("Ram Size = " & myLaptop(a).getRamSize)
                Console.WriteLine("Storage Size = " & myLaptop(a).getStorageSize)
                Console.WriteLine("Touch Screen = " & myLaptop(a).getTouchScreen)
                Console.WriteLine("Removable screen = " & myLaptop(a).getRemovableScreen)
                Console.WriteLine("Tablet Mode = " & myLaptop(a).getTabletMode)
                Console.WriteLine("# of USB 3.0 Ports= " & myLaptop(a).getUSBport)
            Next
        Catch
        End Try
        Console.ReadKey()
    End Sub

    Sub displayMobilePhone()
        Dim i As Integer = 0
        Try
            For i = 0 To phoneCounter
                Console.WriteLine("Code =" & myPhone(i).getCode)
                Console.WriteLine("Computer Width = " & myPhone(i).getComputerWidth)
                Console.WriteLine("Height  = " & myPhone(i).getHeight)
                Console.WriteLine("Computer Weight = " & myPhone(i).getComputerWidth)
                Console.WriteLine("Make = " & myPhone(i).getMake)
                Console.WriteLine("Processor = " & myPhone(i).getProcessor)
                Console.WriteLine("Rim Size = " & myPhone(i).getRamSize)
                Console.WriteLine("Storige Size = " & myPhone(i).getStorageSize)
                Console.WriteLine("Camera = " & myPhone(i).getCamera)
                Console.WriteLine("3G = " & myPhone(i).getNet3G)
                Console.WriteLine("4G = " & myPhone(i).getNet4G)
                Console.WriteLine("Network = " & myPhone(i).getNetwork)
            Next
        Catch
        End Try
        Console.ReadKey()
    End Sub

End Module
