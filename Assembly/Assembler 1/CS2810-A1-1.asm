TITLE CS2650 Assembler Assignment #2 Template

; Student Name: James Painter
; Assignment Due Date: 11/15/2015

INCLUDE Irvine32.inc
.data
	;--------- Enter Data Here
	vsemester byte "CS2810 Fall Semester 2015",0
	vassembler byte "Assembler Assignment #1",0
	vname byte "James Painter",0
.code
main PROC
	;--------- Enter Code Below Here
	call clrscr

; Semester
	mov dh, 2
	mov dl, 12
	call gotoxy
	mov edx, offset vsemester
	call writeString
	
; Assignment
	mov dh, 3
	mov dl, 12
	call gotoxy
	mov edx, offset vassembler
	call writeString
	
; name
	mov dh, 4
	mov dl, 12
	call gotoxy
	mov edx, offset vname
	call writeString
	
; window 
	xor ecx, ecx
	call readchar
	exit
main ENDP

END main