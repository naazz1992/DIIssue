import { DIIssueTemplatePage } from './app.po';

describe('DIIssue App', function() {
  let page: DIIssueTemplatePage;

  beforeEach(() => {
    page = new DIIssueTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
