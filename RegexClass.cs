using System;
using System.Text.RegularExpressions;

namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    class RegexClass
    {
        /// <summary>
        /// 학번 체크 정규식 메서드
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Student_Number_Regex(String value)
        {
            return Regex.IsMatch(value, @"[0-9].{6,7}");  
        }

        /// <summary>
        /// 비밀번호 체크 정규식 메서드
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool PW_Regex(String value)
        {
            return Regex.IsMatch(value, @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,12}");
        }

        /// <summary>
        /// 아이디 체크 정규식 메서드
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns> 
        public bool ID_Regex(String value)
        {
            // 영문 또는 숫자 조합 최소 5자리 ~ 최대 12자리
            return Regex.IsMatch(value, @"^[0-9a-zA-Z]{4,11}$");
        }
    }
}
