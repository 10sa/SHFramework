﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Enum
{
    /// <summary>
    /// 모듈 호출 후 모듈이 반환하는 값입니다.
    /// </summary>
    public enum CallResult
    {
        /// <summary>
        /// 취약점이 있음을 나타냅니다.
        /// </summary>
        Unsafe,

        /// <summary>
        /// 취약점이 없음을 나타냅니다.
        /// </summary>
        Safe,

        /// <summary>
        /// 취약점이 아닌 일반 정보를 반환했음을 나타냅니다.
        /// </summary>
        Status,

        /// <summary>
        /// 예외를 반환했음을 나타냅니다.
        /// </summary>
        Exception
    };

    /// <summary>
    /// 모듈의 호출 규약 및 상태입니다.
    /// </summary>
    public enum ModuleStatus
    {
        /// <summary>
        /// 모듈을 표준 호출함을 나타냅니다.
        /// </summary>
        Call,

		// 현재 미지원, 지원 예정.
        /// <summary>
        /// 모듈을 비동기식으로 호출함을 나타냅니다.
        /// </summary>
        // AsyncCall,

        /// <summary>
        /// 모듈을 스레드를 생성하여 호출함을 나타냅니다.
        /// </summary>
        // ThreadCall,

        /// <summary>
        /// 모듈을 호출하지 않음을 나타냅니다.
        /// </summary>
        DontCall,

        /// <summary>
        /// 모듈에 에러가 있음을 나타냅니다.
        /// </summary>
        Error
    };
}
