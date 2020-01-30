import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Question {

    private String question;
    private String correctAnswer;
    private List<String> answers;

    public Question(String question, List<String> answers) {

        this.question = question;
        this.answers = new ArrayList<>(answers);
        correctAnswer = this.answers.get(0);
    }

    @Override
    public boolean equals(Object other) {

        if (other == this) {

            return true;
        }

        if (!(other instanceof Question)) {

            return false;
        }

        Question otherQuestion = (Question) other;

        return this.question.equals(otherQuestion.question);
    }

    @Override
    public int hashCode() {

        return this.question.hashCode();
    }

    public void shuffleAnswers() {

        Collections.shuffle(answers);
    }
}
