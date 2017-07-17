TITLE CS2810 Assembler Assignment Template

; Student Name: James Painter
; Assignment Due Date: 11/22/2015

INCLUDE Irvine32.inc
.data
	;--------- Enter Data Here
	vsemester byte "CS2810 Fall Semester 2015",0
	vassembler byte "Assembler Assignment #2",0
	vhexcode byte "Enter Hex Value",0
	vname byte "James Painter",0
	vTimeField byte "--:--:--",0
.code
main PROC
	;--------- Enter Code Below Here
	call clrscr


	;CS2810 Fall Semester 2015
	mov dh, 7 ;row
	mov dl, 0 ;col
	call gotoxy
	mov edx, offset vsemester
	call writeString

	;Assignment2
	mov dh, 8 ;row
	mov dl, 0 ;col
	call gotoxy
	mov edx, offset vassembler
	call writeString

	; name
	mov dh, 9 ;row
	mov dl, 0 ;col
	call gotoxy
	mov edx, offset vname
	call writeString

	;Prompt FAT16 time hex
	mov dh, 10 ;row
	mov dl, 0 ;col
	call gotoxy
	mov edx, offset vhexcode
	call writeString
	
	;read hexcode
	mov dh, 11 ;row
	mov dl, 0 ;col
	call gotoxy
	call ReadHex
	ROR AX, 8
	mov ecx, eax
	
	;hour
	AND AX, 1111100000000000b
	SHR AX, 11
	MOV BH, 10
	DIV BH
	ADD AX, 3030h
	mov word ptr [vTimeField+0], AX
	mov eax, ecx
	
	;minutes
	AND AX, 0000011111100000b
	SHR AX, 5
	MOV BH, 10
	DIV BH
	ADD AX, 3030h
	mov word ptr [vTimeField+3], AX
	mov eax, ecx

	;seconds
	AND AX, 0000000000011111b
	SHL AX, 1
	MOV BH, 10
	DIV BH
	ADD AX, 3030h
	mov word ptr [vTimeField+6], AX
	
	
	;Write
	mov dh, 12 ;row
	mov dl, 0 ;col
	call gotoxy
	mov edx, OFFSET vTimefield
	call WriteString

	xor ecx, ecx
	call readchar

	exit
main ENDP

END main