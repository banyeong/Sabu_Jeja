using System.Runtime.InteropServices.ComTypes;

/*public class Story
{
	public int index; //로드할때 쓸 인덱스
	public stat goalStat; //목표 점수 
	public int priority; //우선 순위(스토리 점수)
}

//모든 스토리 ( index, stat{ 0, 0, 0, 0 }, priority )
private Story[] storys =
						{
							new Story() { 2, new stat{ -1, -1, -1, -1 }, 0 }, //1
							new Story() { 3, new stat{ 300, -1, -1, -1 }, 20 }, //2
							new Story() { 4, new stat{ -1, 300, -1, -1 }, 30 }, //3
							new Story() { 5, new stat{ -1, -1, 500, -1 }, 40 }, //4
							new Story() { 6, new stat{ -1, -1, -1, 300 }, 60 }, //5
							new Story() { 7, new stat{ 500, 500, -1, -1 }, 70 }, //6
							new Story() { 8, new stat{ -1, 300, -1, -1 }, 80 }, //7
							new Story() { 9, new stat{ 500, 300, -1, 500 }, 90 }, //8
							new Story() { 10, new stat{ -1, 500, 500, 500 }, 110 }, //9
							new Story() { 11, new stat{ 800, 500, -1, 500 }, 150 }, //10
							new Story() { 12, new stat{ 500, 800, -1, 500 }, 170 }, //11
							new Story() { 0, new stat{ 800, 800, -1, 500 }, 200 }, //12
						};

public void StoryProgress()
{
	Story curStory = null; //로드할 스토리

	foreach(Story story in storys) //foreach 반복문
	{
		if(story.goalStat.currentMslStr < stat.currentMslStr && stroy.goalStat.currentMoralStr < stat.currentMoralStr
			&& story.goalStat.currentWealth < stat.currentWealth && story.goalStat.cureentFavorability < stat.cureentFavorability) //모든 조건 검사
		{
			if(curStory != null) //만약 조건에 부합하는 스토리가 이미 존재했을경우
			{
				//우선순위를 비교하고 curStory에 넣어준다.
				curStory = story.priority < curStory.priority ? curStory : story;
			}
			else //만약 조건에 부합하는 스토리가 최초일경우
			{
				//curStory에 넣어준다.
				curStory = story;
			}
		}
	}

	//curStory의 index로 Scene을 Load한다.
	SceneMangaer.Load(curStory.index);
}*/
