import QuestionCard from '@/components/QuestionCard.vue'

/* eslint-disable-next-line no-unused-vars */
import { shallowMount, Wrapper } from '@vue/test-utils';

import chai from 'chai';

chai.should();

function buildTestQuestion(isCorrect, isAnswerVisible) {
    return {
        question: "Test Question",
        answer: "Test Answer",
        tags: ["testing"],
        learnMoreUrl: "https://www.google.com",
        difficulty: 1,
        isCorrect: isCorrect,
        isAnswerVisible: isAnswerVisible
    };
}

describe('QuestionCard.vue', () => {

    /** @type Wrapper */
    let wrapper;
    beforeEach(() => {
        wrapper = shallowMount(QuestionCard);
    });

    // Hello Vue - simple test to make sure Vue mounted it without issue. Will detect template errors
    it('should be a Vue instance', () => {
        wrapper.isVueInstance().should.be.true;
    });

    // Method tests
    it('marks question as visible when showAnswer executes', () => {
        // Arrange
        wrapper.setData({question: buildTestQuestion(undefined, false)});

        // Act
        wrapper.vm.showAnswer();

        // Assert
        wrapper.vm.question.isAnswerVisible.should.equal(true);
    });

    it('marks question as correct when markCorrect executes', () => {
        // Arrange
        wrapper.setData({question: buildTestQuestion(undefined, false)});

        // Act
        wrapper.vm.markCorrect();

        // Assert
        wrapper.vm.question.isCorrect.should.be.true;
    });

    // Computed Property Tests
    it('computes isMarkCorrectVisible to false when answer is hidden', () => {
        wrapper.setData({question: buildTestQuestion(undefined, false)});

        wrapper.vm.isMarkCorrectVisible.should.be.false;
    });
    
    it('computes isMarkCorrectVisible to true when answer is shown and question is not graded', () => {
        wrapper.setData({question: buildTestQuestion(undefined, true)});

        wrapper.vm.isMarkCorrectVisible.should.be.true;
    });    

    
    it('computes isMarkCorrectVisible to true when answer is shown and question is incorrect', () => {
        wrapper.setData({question: buildTestQuestion(false, true)});

        wrapper.vm.isMarkCorrectVisible.should.be.true;
    });    
    
    it('computes isMarkCorrectVisible to false when answer is shown and question is correct', () => {
        wrapper.setData({question: buildTestQuestion(true, true)});

        wrapper.vm.isMarkCorrectVisible.should.be.false;
    });        
});
