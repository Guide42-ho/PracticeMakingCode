import java.util.Scanner;
public class Supernova {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("search :");
        String a = input.nextLine();

        String text = "I'm like some kind of supernova\n" + "Watch out\n" + "Look at me go, 재미 좀 볼\n" + "빛의 core, so hot, hot\n" + "문이 열려 서로의 존재를 느껴\n" + "마치 Discord, 날 닮은 너 (incoming!), 너 누구야? (Drop)\n" + "사건은 다가와, ah-oh, ayy\n" + "거세게 커져가, ah-oh, ayy\n" + "That tick, that tick, tick bomb\n" + "That tick, that tick, tick bomb\n" + "감히 건드리지 못할 걸 (누구도 말이야)\n" + "지금 내 안에선 (su-su-su-supernova)\n" + "Nova, can't stop hyperstellar\n" + "원초 그걸 찾아\n" + "Bring the light of a dying star\n" + "불러낸 내 우주를 봐봐, supernova\n" + "Ah, body bang (bang, bang, bang)\n" + "Make it feel too right\n" + "휩쓸린 energy, it's so special\n" + "잔인한 queen 이며 scene 이자 종결\n" + "이토록 거대한 내 안의 explosion\n" + "내 모든 세포 별로부터 만들어져 (under my control)\n" + "질문은 계속돼, ah-oh, ayy\n" + "우린 어디서 왔나, oh, ayy\n" + "느껴 내 안에선, huh (su-su-su-supernova)\n" + "Nova, can't stop hyperstellar\n" + "원초 그걸 찾아\n" + "Bring the light of a dying star\n" + "불러낸 내 우주를 봐봐, supernova\n" + "보이지 않는 힘으로 네게 손 내밀어 볼까?\n" + "가능한 모든 가능성, 무한 속의 너를 만나\n" + "It's about to bang, bang, don't forget my name\n" + "Su-su-su-supernova\n" + "사건은 다가와, ah-oh, ayy\n" + "거세게 커져가, ah-oh, ayy\n" + "질문은 계속돼, ah-oh, ayy\n" + "우린 어디서 왔나, oh, ayy\n" + "사건은 다가와, ah-oh, ayy\n" + "거세게 커져가, ah-oh, ayy\n" + "Tell me, tell me, tell me, oh, ayy\n" + "우린 어디서 왔나, oh, ayy, 우린 어디서 왔나, oh, ayy\n" + "Nova (nova), can't stop hyperstellar\n" + "(Hyperstellar) 원초 그걸 찾아\n" + "Bring the light of a dying star (light of a dying star)\n" + "불러낸 내 우주를 봐봐 (all the way), supernova (hey, huh)\n" + "사건은 다가와, ah-oh, ayy (new star)\n" + "거세게 커져가, ah-oh, ayy\n" + "질문은 계속돼 (nova), ah-oh, ayy (ah-ah)\n" + "우린 어디서 왔나, oh, ayy\n" + "사건은 다가와, ah-oh, ayy (yeah, yeah, yeah, yеah)\n" + "거세게 커져가, ah-oh, ayy (nova)\n" + "질문은 계속돼, ah-oh, ayy (bring the light of a dying star)\n" + "Supernova";
        String [] k= text.split(a);
         
        int f = k.length;
        
        System.out.print("\""+ a +"\"" + "appears "+ (f - 1) +" times here.");
             
    }
}