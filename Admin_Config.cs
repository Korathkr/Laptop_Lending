using System;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    class Admin_Config
    {
        public static String ID; // 아이디
        public static String Name; // 이름
        public static String Student_Number; // 학번
        public static String Birth; // 생일
        public static String Tell; // 전화번호
        public static String[] Address = new String[2]; // 주소
        public static String Email; // 이메일
        public static String Dept_ID; // 학과명
        public static String Dept_Name; // 전공이름
        public static String Parent_Name; // 보호자 성명
        public static String Parent_Tell; // 보호자 연락처
        public static String Parent_Address; // 보호자 주소
        public static String Rental_Date; // 대여 일자
        public static String Return_Date; // 반납 일자
        public static String Application_Date; // 신청 일자
        public static String Late; // 연체 여부
        public static String[] PW_QA = new String[3]; // 비밀번호 Q/A
    }
}
