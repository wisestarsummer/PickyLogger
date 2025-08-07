# 🧾 PickyLogger

**PickyLogger**는 다수의 `.txt` 또는 `.log` 파일에서 특정 문자열이 포함된 라인만 추출하여 하나의 파일로 저장해주는 간단한 필터링 툴입니다.  
로깅된 데이터 중 관심 있는 정보만 골라내고 싶을 때 유용하게 사용할 수 있습니다.

---

## 💡 주요 기능

- 다중 파일 선택 (`.txt`, `.log`)
- 필터 문자열 입력
- 필터 문자열을 포함한 라인만 결과 파일에 저장
- 저장 경로 지정 및 열기
- 로그 영역에서 진행 상황 확인

---

## 🖥️ 사용자 인터페이스
<img width="878" height="906" alt="image" src="https://github.com/user-attachments/assets/0101a114-a4e6-4d2d-8b28-01c004e337a3" />

---

## 🚀 사용 방법

### 1. 실행
`.exe` 파일을 실행하세요.

### 2. 파일 선택
`Select Files` 버튼을 눌러 `.txt` 또는 `.log` 파일을 선택합니다. (다중 선택 가능)

### 3. 필터 입력
`Filter String` 입력란에 검색할 문자열을 입력하세요.
- **여러 문자열을 동시에 검색**하고 싶다면, 각 문자열을 줄바꿈(Enter)으로 구분하여 입력하면 됩니다.
- 예:  아래와 같이 입력하면, `error`, `warning`, `timeout` 중 하나라도 포함하는 모든 줄이 필터링됩니다.  
```
error  
warning  
timeout
```

### 4. 저장 경로 지정
- `Select Save Path` 버튼을 눌러 결과를 저장할 파일의 경로를 지정합니다.
- `Open Save Path` 버튼을 통해 경로 지정된 파일을 바로 열 수 있습니다.

### 5. 실행
`Execute` 버튼을 눌러 필터링을 수행하고 결과를 저장합니다.

### 6. 로그 확인
하단의 `Log` 영역에서 처리 결과와 진행 상태를 확인할 수 있습니다.

---

## 📁 다운로드

릴리즈 페이지에서 최신 버전을 다운로드하세요:  
[🔗 GitHub Releases](https://github.com/wisestarsummer/PickyLogger/releases)  
→ `.zip` 다운로드 후 압축 해제 및 `.exe` 실행

---

## 🔧 개발 환경

- Language: **C#**
- Framework: **.NET 8.0 (Windows)**  
- UI: **Windows Forms**
- 개발 IDE: **Visual Studio 2022**
- 배포: **GitHub Releases를 통한 수동 실행 파일 배포 (.exe)**

---

## 📃 라이선스

MIT License. 자유롭게 사용 및 수정 가능합니다.

---

## 🤝 기여

Pull request 및 피드백 환영합니다!

