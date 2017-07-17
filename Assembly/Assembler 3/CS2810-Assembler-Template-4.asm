TITLE CS2810 Assembler Assignment Template

; Student Name: James Painter
; Assignment Due Date: 11/22/2015

INCLUDE Irvine32.inc
.data
	;--------- Enter Data Here
	vsemester byte "CS2810 Fall Semester 2015",0
	vassembler byte "Assembler Assignment #3",0
	vhexcode byte "Enter Hex Value",0
	vname byte "James Painter",0
	vMpeg25 byte "MPEG Version 2.5",0
	vMpeg20 byte "MPEG Version 2.0",0
	vMpeg10 byte "MPEG Version 1.0",0
	VMpegRE byte "MPEG Reserved",0
	VReserved byte "Reserved",0
	VLayerIII byte "Layer III",0
	VLayerII byte "Layer II",0
	VLayerI byte "Layer I",0
	VSRFMPEG100 byte "44100 HZ",0
	VSRFMPEG200 byte "22050 HZ",0
	VSRFMPEG2500 byte "11025 HZ",0
	VSRFMPEG101 byte "48000 Hz",0
	VSRFMPEG201 byte "24000 Hz",0
	VSRFMPEG2501 byte "12000 Hz",0
	VSRFMPEG110 byte "32000 Hz",0
	VSRFMPEG210 byte "16000 Hz",0
	VSRFMPEG2510 byte "8000 Hz",0
	VSRFMPEG111 byte "reserv.",0
	VSRFMPEG211 byte "reserv.",0
	VSRFMPEG2511 byte "reserv.",0



.code
main PROC
	;--------- Enter Code Below Here
	call clrscr

	;stack
	
	call DisplaySemester
	call DisplayAssignment
	call DisplayName
	call ReadMP3Header
	call RHex
	call DisplayVersion
	call DisplayLayerDesc
	call DisplaySamplingRate
	
	xor ecx, ecx
	call readchar

	exit
	

DisplaySemester:
	;CS2810 Fall Semester 2015
	mov dh, 12 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vsemester
	jmp DisplayString
	ret

DisplayAssignment:
	;Assignment3
	mov dh, 13 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vassembler
	jmp DisplayString
	ret

DisplayName:
	; name
	mov dh, 14 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vname
	jmp DisplayString
	ret

ReadMP3Header:
	;Prompt MP3Header
	mov dh, 15 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vhexcode
	jmp DisplayString
	ret

RHex:
	mov dh, 16 ;row
	mov dl, 12 ;col
	call gotoxy
	;Pop edx
	call ReadHex
	;ROR AX, 8
	mov ecx, eax
	;Push eax
	;jmp DisplayVersion
	ret

DisplayVersion:
	       ;AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMM
	and eax,00000000000110000000000000000000b
	shr eax,19

;if
cmp eax, 00b
	jz dMpeg25
cmp eax, 01b
	jz dMpegRE
cmp eax, 10b
	jz dMpeg20

;else	
	mov dh, 17 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vMpeg10
	jmp DisplayString
	
;then
dMpeg25:
	mov dh, 17 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vMpeg25
	jmp DisplayString

dMpegRE:
	mov dh, 17 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vMpegRE
	jmp DisplayString

dMpeg20:
	mov dh, 17 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vMpeg20
	jmp DisplayString
ret


;display layer description
DisplayLayerDesc:
	mov eax, ecx
	       ;AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMM
	and eax,00000000000001100000000000000000b
	shr eax,17

;if
cmp eax, 00b
	jz res
cmp eax, 01b
	jz LIII
cmp eax, 10b
	jz LII

;else	
	mov dh, 18 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vLayerI
	jmp DisplayString

;then
res:
	mov dh, 18 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VReserved
	jmp DisplayString

LIII:
	mov dh, 18 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VLayerIII
	jmp DisplayString

LII:
	mov dh, 17 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset vLayerII
	jmp DisplayString
	
ret
	
	
	
DisplaySamplingRate:
	mov eax, ecx
;MPEG VERSION
		   ;AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMM
	and eax,00000000000110000000000000000000b
	shr eax,19
	
	;Sampling rate frequency index
		   ;AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMM
	and ecx,00000000000000000000110000000000b
	shr ecx,10

;if
cmp ecx, 00b ; 11025 HZ
	jz MPEG1
cmp ecx, 01b ; 12000 Hz
	jz MPEG2
cmp esi, 10b ; 8000 Hz
	jz MPEG3
cmp ecx, 11b ; 8000 Hz
	jz MPEG4


cmp ecx, 00b ; 22050 Hz
    jz MPEG1
cmp ecx, 01b ; 24000 Hz
	jz MPEG2
cmp ecx, 10b ; 16000 Hz
	jz MPEG3
cmp ecx, 11b ; reserved2
	jz MPEG4


cmp ecx, 00b ; 44100 Hz
	jz MPEG1
cmp ecx, 01b ; 48000 Hz
	jz MPEG2
cmp ecx, 10b ; 32000 Hz
	jz MPEG3
cmp ecx, 11b ; reserv.
	jz MPEG4

;new 
MPeg1:
cmp eax, 00b ;MPEG2.5
	jz F11025h
cmp eax, 10b ;MPEG2
	jz F22050h
cmp eax, 11b ;MPEG1	
	jz F44100h

MPEG2:
cmp eax, 00b ;MPEG2.5
	jz F12000h
cmp eax, 10b ;MPEG2
	jz TF24000h
cmp eax, 11b ;MPEG1	
	jz F48000h

MPEG3:
cmp eax, 00b ;MPEG2.5
	jz F8000h
cmp eax, 10b ;MPEG2
	jz F16000h
cmp eax, 11b ;MPEG1	
	jz F32000h

MPEG4:
cmp eax, 00b ;MPEG2.5
	jz Fr25h
cmp eax, 10b ;MPEG2
	jz Freserved2
cmp eax, 11b ;MPEG1	
	jz Freserved3

;then
F11025h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG2500
	jmp DisplayString
	


F12000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG2501
	jmp DisplayString


F8000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG2510
	jmp DisplayString

Fr25h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG2511
	jmp DisplayString

F22050h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG200
	jmp DisplayString

TF24000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG201
	jmp DisplayString

F16000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG210
	jmp DisplayString

Freserved2:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG211
	jmp DisplayString

F44100h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG100
	jmp DisplayString

F48000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG101
	jmp DisplayString

F32000h:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG110
	jmp DisplayString

Freserved3:
mov dh, 19 ;row
	mov dl, 12 ;col
	call gotoxy
	mov edx, offset VSRFMPEG111
	jmp DisplayString
	
ret

DisplayString:
	call WriteString
ret

	
main ENDP

END main