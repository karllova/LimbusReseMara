namespace LimbusReseMara;

public class info
{
    public int point { get; private set; }
    public int star { get; private set; }

    public info(int p, int s)
    {
        point = p;
        star = s;
    }
}
public class Dict
{
    private Dictionary<string, info> charInfo;
    
    public Dict()
    {
        charInfo = new Dictionary<string, info>();
        #region tier0
        charInfo.Add("검계 우두머리 뫼르소",new info(50,3));
        charInfo.Add("R사 제4무리 토끼팀 히스클리프",new info(50,3));
        charInfo.Add("피쿼드호 선장 이스마엘",new info(50,3));
        charInfo.Add("남부 섕크 협회 4과 부장 싱클레어",new info(50,3));
        #endregion

        #region tier05
        charInfo.Add("로보토미 E.G.O:: 후회 파우스트",new info(40,3));
        charInfo.Add("에드가 가문 치프 버틀러 료슈",new info(40,3));
        charInfo.Add("K사 3등급 적출직 직원 홍루",new info(40,3));
        charInfo.Add("피쿼드호 작살잡이 히스클리프",new info(40,3));
        charInfo.Add("남부 디에치 협회 4과 로쟈",new info(40,3));
        charInfo.Add("쥐어들 자 싱클레어",new info(40,3));
        charInfo.Add("새벽 사무소 해결사 싱클레어",new info(40,3));
        #endregion

        #region tier1
        charInfo.Add("로보토미 E.G.O:: 마탄 오티스",new info(25,3));
        charInfo.Add("어금니 보트 센터 해결사 이스마엘",new info(25,3));
        charInfo.Add("남부 디에치 협회 4과 홍루",new info(25,3));
        charInfo.Add("검계 살수 파우스트",new info(25,3));
        charInfo.Add("남부 세븐 협회 4과 파우스트",new info(25,3));
        charInfo.Add("개화 E.G.O:: 동백 이상",new info(25,3));
        #endregion

        #region tier15
        charInfo.Add("W사 3등급 정리 요원 이상",new info(15,3));
        charInfo.Add("중지 작은 아우 돈키호테",new info(15,3));
        charInfo.Add("W사 3등급 정리 요원 료슈",new info(15,3));
        charInfo.Add("콩콩이파 두목 홍루",new info(15,3));
        charInfo.Add("워더링하이츠 치프 버틀러 오티스",new info(15,3));
        charInfo.Add("어금니 사무소 해결사 오티스",new info(15,3));
        charInfo.Add("쌍갈고리 해적단 부선장 그레고르",new info(15,3));
        charInfo.Add("에드가 가문 승계자 그레고르",new info(15,3));
        
        #endregion

        #region tier2
        charInfo.Add("검계 살수 이상",new info(10,3));
        charInfo.Add("쥐는 자 파우스트",new info(10,3));
        charInfo.Add("W사 3등급 정리 요원 돈키호테",new info(10,3));
        charInfo.Add("남부 섕크 협회 5과 부장 돈키호테",new info(10,3));
        charInfo.Add("흑운회 와카슈 료슈",new info(10,3));
        charInfo.Add("료.고.파. 주방장 료슈",new info(10,3));
        charInfo.Add("남부 외우피 협회 3과 히스클리프",new info(10,3));
        charInfo.Add("남부 리우 협회 4과 이스마엘",new info(10,3));
        charInfo.Add("남부 리우 협회 4과 부장 로쟈",new info(10,3));
        charInfo.Add("남부 츠바이 협회 4과 그레고르",new info(10,3));
        #endregion

        #region tier3
        charInfo.Add("W사 2등급 정리 요원 뫼르소",new info(0,3));
        charInfo.Add("N사 큰 망치 뫼르소",new info(0,3));
        charInfo.Add("R사 제 4무리 코뿔소팀 뫼르소",new info(0,3));
        charInfo.Add("로보토미 E.G.O:: 여우비 히스클리프",new info(0,3));
        charInfo.Add("R사 제 4무리 순록팀 이스마엘",new info(0,3));
        charInfo.Add("흑운회 와카슈 로쟈",new info(0,3));
        charInfo.Add("장미스패너 공방 대표 로쟈",new info(0,3));
        charInfo.Add("검계 살수 싱클레어",new info(0,3));
        charInfo.Add("남부 세븐 협회 6과 부장 오티스",new info(0,3));
        charInfo.Add("G사 일등대리 그레고르",new info(0,3));
        #endregion

        #region star2
        charInfo.Add("피쿼드호 일등항해사 이상",new info(10,2));
        charInfo.Add("살아남은 로보토미 직원 파우스트",new info(10,2));
        charInfo.Add("남부 시 협회 5과 부장 돈키호테",new info(10,2));
        charInfo.Add("검계 살수 돈키호테",new info(10,2));
        charInfo.Add("남부 세븐 협회 6과 료슈",new info(10,2));
        charInfo.Add("중지 작은 아우 뫼르소",new info(10,2));
        charInfo.Add("데드레빗츠 보스 뫼르소",new info(10,2));
        charInfo.Add("흑운회 와카슈 홍루",new info(10,2));
        charInfo.Add("갈고리 사무소 해결사 홍루",new info(10,2));
        charInfo.Add("남부 세븐 협회 4과 히스클리프",new info(10,2));
        charInfo.Add("워더링하이츠 버틀러 파우스트",new info(10,2));
        charInfo.Add("에드가 가문 버틀러 이스마엘",new info(10,2));
        charInfo.Add("로보토미 E.G.O:: 초롱 돈키호테",new info(10,2));
        #endregion
    }

    public int[] GetValue(string value)
    {
        int[] ret = new int[2];
        ret[0] = charInfo[value].point;
        ret[1] = charInfo[value].star;
        return ret;
    }
}